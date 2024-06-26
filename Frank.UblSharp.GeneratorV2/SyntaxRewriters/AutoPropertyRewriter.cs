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

                    // Annotate the property to identify it later
                    newProperty = newProperty.WithAdditionalAnnotations(new SyntaxAnnotation("AutoProperty"));

                    return newProperty;
                }
            }
        }

        return base.VisitPropertyDeclaration(node);
    }

    public SyntaxNode Transform(SyntaxNode root)
    {
        var newRoot = Visit(root);

        // Remove backing fields
        var annotatedProperties = newRoot.GetAnnotatedNodes("AutoProperty").OfType<PropertyDeclarationSyntax>();
        foreach (var property in annotatedProperties)
        {
            var fieldName = GetBackingField(property);
            if (fieldName == null) continue;
            var fieldNode = newRoot.DescendantNodes().OfType<FieldDeclarationSyntax>()
                .FirstOrDefault(f => f.Declaration.Variables.Any(v => v.Identifier.Text == fieldName));

            if (fieldNode != null)
            {
                newRoot = newRoot.RemoveNode(fieldNode, SyntaxRemoveOptions.KeepNoTrivia);
            }
        }

        // Replace field references with property references
        foreach (var property in annotatedProperties)
        {
            var fieldName = GetBackingField(property);
            if (fieldName != null)
            {
                var rewriter = new FieldReferenceRewriter(fieldName, property.Identifier.Text);
                newRoot = rewriter.Visit(newRoot);
            }
        }

        return newRoot;
    }

    private string GetBackingField(PropertyDeclarationSyntax property)
    {
        var propertySymbol = _semanticModel.GetDeclaredSymbol(property) as IPropertySymbol;
        if (propertySymbol != null)
        {
            foreach (var accessor in propertySymbol.GetMethod.DeclaringSyntaxReferences.Concat(propertySymbol.SetMethod.DeclaringSyntaxReferences))
            {
                var syntaxNode = accessor.GetSyntax() as AccessorDeclarationSyntax;
                var identifier = syntaxNode?.DescendantNodes().OfType<IdentifierNameSyntax>().FirstOrDefault();
                if (identifier != null)
                {
                    return identifier.Identifier.Text;
                }
            }
        }

        return null;
    }
}