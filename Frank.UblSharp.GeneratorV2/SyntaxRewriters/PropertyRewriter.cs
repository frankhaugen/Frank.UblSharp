using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Frank.UblSharp.GeneratorV2.SyntaxRewriters;

public class AutoPropertyRewriter : CSharpSyntaxRewriter
{
    private SemanticModel _semanticModel;

    public AutoPropertyRewriter(SemanticModel semanticModel)
    {
        _semanticModel = semanticModel;
    }

    public override SyntaxNode VisitPropertyDeclaration(PropertyDeclarationSyntax node)
    {
        Console.WriteLine($"Visiting property {node.Identifier.Text}");
        if (node.AccessorList != null && node.AccessorList.Accessors.Count == 2)
        {
            Console.WriteLine($"Property {node.Identifier.Text} has two accessors");
            var getAccessor = node.AccessorList.Accessors.FirstOrDefault(a => a.Kind() == SyntaxKind.GetAccessorDeclaration);
            var setAccessor = node.AccessorList.Accessors.FirstOrDefault(a => a.Kind() == SyntaxKind.SetAccessorDeclaration);

            if (getAccessor == null || setAccessor == null ||
                getAccessor.Body != null || setAccessor.Body != null) return base.VisitPropertyDeclaration(node);
            
            Console.WriteLine($"Property {node.Identifier.Text} has no body in accessors");
            var fieldName = GetBackingField(node);
            if (fieldName == null) return base.VisitPropertyDeclaration(node);
            
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
                .WithTriviaFrom(node);

            // Replace references to the backing field in the property
            newProperty = newProperty.ReplaceNodes(newProperty.DescendantNodes().OfType<IdentifierNameSyntax>(), 
                (identifierNode, _) => identifierNode.Identifier.Text == fieldName ? 
                    SyntaxFactory.IdentifierName(newProperty.Identifier.Text) : identifierNode);

            return newProperty;
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

    private static string GetBackingField(PropertyDeclarationSyntax property)
    {
        var fieldName = property.Identifier.Text;
        if (fieldName.Length > 1 && char.IsUpper(fieldName[1]))
        {
            fieldName = char.ToLowerInvariant(fieldName[0]) + fieldName.Substring(1);
        }

        if (fieldName.StartsWith("_"))
        {
            fieldName = fieldName.Substring(2);
        }

        return fieldName;
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
                var backingFieldName = GetBackingField((PropertyDeclarationSyntax)property.DeclaringSyntaxReferences.First().GetSyntax());
                if (backingFieldName == fieldName)
                {
                    return true;
                }
            }
        }

        return false;
    }
}