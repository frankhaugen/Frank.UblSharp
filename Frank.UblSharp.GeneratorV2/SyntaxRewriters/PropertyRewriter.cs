using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Frank.UblSharp.GeneratorV2.SyntaxRewriters;

public class AutoPropertyRewriter : CSharpSyntaxRewriter
{
    private readonly SemanticModel _semanticModel;

    public AutoPropertyRewriter(SemanticModel semanticModel)
    {
        _semanticModel = semanticModel;
    }

    public override SyntaxNode VisitPropertyDeclaration(PropertyDeclarationSyntax node)
    {
        if (node.AccessorList != null && node.AccessorList.Accessors.Count == 2)
        {
            var getAccessor = node.AccessorList.Accessors.FirstOrDefault(a => a.Kind() == SyntaxKind.GetAccessorDeclaration);
            var setAccessor = node.AccessorList.Accessors.FirstOrDefault(a => a.Kind() == SyntaxKind.SetAccessorDeclaration);

            if (getAccessor != null && setAccessor != null &&
                getAccessor.Body == null && setAccessor.Body == null)
            {
                var fieldName = GetBackingField(node);
                if (fieldName != null)
                {
                    // Create a new property declaration with auto-property syntax and preserve the attributes
                    var newProperty = node
                        .WithAccessorList(SyntaxFactory.AccessorList(SyntaxFactory.List(new[]
                        {
                            SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                                .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)),
                            SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration)
                                .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken))
                        })))
                        .WithTrailingTrivia(SyntaxFactory.Whitespace(Environment.NewLine))
                        .WithLeadingTrivia(node.GetLeadingTrivia())
                        .WithTriviaFrom(node)
                        .WithModifiers(node.Modifiers);

                    // Replace references to the backing field in the class
                    var root = node.SyntaxTree.GetRoot();
                    var rewriter = new FieldReferenceRewriter(fieldName, node.Identifier.Text);
                    root = rewriter.Visit(root);

                    // Update the syntax tree with the new root
                    return newProperty.WithAdditionalAnnotations(new SyntaxAnnotation("NeedsRemoval", fieldName));
                }
            }
        }

        return base.VisitPropertyDeclaration(node);
    }

    public SyntaxNode Transform(SyntaxNode root)
    {
        var newRoot = Visit(root);

        // Remove annotated fields
        var annotatedNodes = newRoot.GetAnnotatedNodes("NeedsRemoval");
        foreach (var node in annotatedNodes)
        {
            var fieldName = node.GetAnnotations("NeedsRemoval").FirstOrDefault()?.Data;
            if (fieldName != null)
            {
                var fieldNode = newRoot.DescendantNodes().OfType<FieldDeclarationSyntax>()
                    .FirstOrDefault(f => f.Declaration.Variables.Any(v => v.Identifier.Text == fieldName));

                if (fieldNode != null)
                {
                    newRoot = newRoot.RemoveNode(fieldNode, SyntaxRemoveOptions.KeepNoTrivia);
                }
            }
        }

        return newRoot;
    }

    private string GetBackingField(PropertyDeclarationSyntax property)
    {
        var propertySymbol = _semanticModel.GetDeclaredSymbol(property) as IPropertySymbol;
        if (propertySymbol != null)
        {
            var containingType = propertySymbol.ContainingType;
            var fields = containingType.GetMembers().OfType<IFieldSymbol>();
            foreach (var field in fields)
            {
                if (field.AssociatedSymbol == propertySymbol)
                {
                    return field.Name;
                }
            }
        }

        return null;
    }

    private bool IsBackingField(string fieldName)
    {
        var symbol = _semanticModel.LookupSymbols(0, name: fieldName).FirstOrDefault();
        if (symbol is IFieldSymbol fieldSymbol)
        {
            var containingType = fieldSymbol.ContainingType;
            var properties = containingType.GetMembers().OfType<IPropertySymbol>();
            foreach (var property in properties)
            {
                var propertyNode = (PropertyDeclarationSyntax)property.DeclaringSyntaxReferences.First().GetSyntax();
                var backingFieldName = GetBackingField(propertyNode);
                if (backingFieldName == fieldName)
                {
                    return true;
                }
            }
        }

        return false;
    }
}