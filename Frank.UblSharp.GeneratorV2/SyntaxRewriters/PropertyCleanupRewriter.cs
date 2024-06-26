using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Frank.UblSharp.GeneratorV2.SyntaxRewriters;

/// <summary>
/// Rewrites the syntax tree to clean up properties and make them auto-properties, ([Accessor] [Type] [Name] { get; set; }).
/// </summary>
public class PropertyCleanupRewriter : CSharpSyntaxRewriter
{
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
                        .WithTriviaFrom(node);

                    // Remove references to the backing field in the property
                    return newProperty.ReplaceNodes(newProperty.DescendantNodes().OfType<IdentifierNameSyntax>(), 
                        (identifierNode, _) => identifierNode.Identifier.Text == fieldName ? 
                        SyntaxFactory.IdentifierName(newProperty.Identifier.Text) : identifierNode);
                }
            }
        }

        return base.VisitPropertyDeclaration(node);
    }

    private static string GetBackingField(PropertyDeclarationSyntax property)
    {
        var fieldName = property.Identifier.Text;
        if (fieldName.Length > 1 && char.IsUpper(fieldName[1]))
        {
            fieldName = char.ToLowerInvariant(fieldName[0]) + fieldName.Substring(1);
        }

        if (fieldName.StartsWith("m_"))
        {
            fieldName = fieldName.Substring(2);
        }

        return fieldName;
    }
}