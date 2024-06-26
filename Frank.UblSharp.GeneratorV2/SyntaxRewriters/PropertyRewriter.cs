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
                    node = root.DescendantNodes().OfType<PropertyDeclarationSyntax>().FirstOrDefault(p => p.Identifier.Text == node.Identifier.Text);
                    return newProperty;
                }
            }
        }

        return base.VisitPropertyDeclaration(node);
    }

    public override SyntaxNode VisitFieldDeclaration(FieldDeclarationSyntax node)
    {
        // Determine if the field is a backing field that needs removal
        var variableName = node.Declaration.Variables.First().Identifier.Text;
        var isBackingField = IsBackingField(variableName);

        if (isBackingField)
        {
            // Remove the field by returning null
            return null;
        }

        return base.VisitFieldDeclaration(node);
    }

    private string GetBackingField(PropertyDeclarationSyntax property)
    {
        var semanticModel = _semanticModel;
        var propertySymbol = semanticModel.GetDeclaredSymbol(property) as IPropertySymbol;
        if (propertySymbol != null)
        {
            foreach (var syntaxReference in propertySymbol.DeclaringSyntaxReferences)
            {
                var propertyNode = syntaxReference.GetSyntax() as PropertyDeclarationSyntax;
                if (propertyNode == property)
                {
                    var containingType = propertySymbol.ContainingType;
                    var fields = containingType.GetMembers().OfType<IFieldSymbol>();
                    foreach (var field in fields)
                    {
                        if (field.DeclaringSyntaxReferences.Any())
                        {
                            var fieldDeclaration = field.DeclaringSyntaxReferences.First().GetSyntax() as VariableDeclaratorSyntax;
                            if (fieldDeclaration != null)
                            {
                                return fieldDeclaration.Identifier.Text;
                            }
                        }
                    }
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