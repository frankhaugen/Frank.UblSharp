using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Frank.UblSharp.GeneratorV2.SyntaxRewriters;

public class FieldRewriter : CSharpSyntaxRewriter
{
    public override SyntaxNode VisitClassDeclaration(ClassDeclarationSyntax node)
    {
        var updatedClass = base.VisitClassDeclaration(node) as ClassDeclarationSyntax;

        if (updatedClass != null)
        {
            // Remove fields that were converted to auto-properties
            var fieldsToRemove = updatedClass.Members.OfType<FieldDeclarationSyntax>()
                .Where(f => updatedClass.Members.OfType<PropertyDeclarationSyntax>()
                    .Any(p => IsBackingField(f, p)))
                .ToList();

            updatedClass = updatedClass.RemoveNodes(fieldsToRemove, SyntaxRemoveOptions.KeepNoTrivia);
        }

        return updatedClass;
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
                        .WithTriviaFrom(node);

                    return newProperty;
                }
            }
        }

        return base.VisitPropertyDeclaration(node);
    }

    private string? GetBackingField(PropertyDeclarationSyntax property)
    {
        var classDeclaration = property.Ancestors().OfType<ClassDeclarationSyntax>().FirstOrDefault();
        if (classDeclaration == null) return null;

        // Find the field with a similar name to the property
        var fieldName = property.Identifier.Text;
        var backingField = classDeclaration.Members
            .OfType<FieldDeclarationSyntax>()
            .FirstOrDefault(f =>
            {
                var fieldIdentifier = f.Declaration.Variables.First().Identifier.Text;
                return string.Equals(fieldIdentifier.TrimStart('_'), fieldName, StringComparison.OrdinalIgnoreCase);
            });

        return backingField?.Declaration.Variables.First().Identifier.Text;
    }

    private bool IsBackingField(FieldDeclarationSyntax field, PropertyDeclarationSyntax property)
    {
        var fieldName = field.Declaration.Variables.First().Identifier.Text;
        var propertyName = property.Identifier.Text;

        return string.Equals(fieldName.TrimStart('_'), propertyName, StringComparison.OrdinalIgnoreCase);
    }
}