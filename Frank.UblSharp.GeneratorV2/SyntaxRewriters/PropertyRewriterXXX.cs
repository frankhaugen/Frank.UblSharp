using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Frank.UblSharp.GeneratorV2.SyntaxRewriters;

public class PropertyRewriterXXX : CSharpSyntaxRewriter
{
    public override SyntaxNode VisitClassDeclaration(ClassDeclarationSyntax node)
    {
        var updatedClass = base.VisitClassDeclaration(node) as ClassDeclarationSyntax;

        if (updatedClass != null)
        {
            // Identify fields that are backing fields for properties
            var fieldsToRemove = updatedClass.Members.OfType<FieldDeclarationSyntax>()
                .Where(f => updatedClass.Members.OfType<PropertyDeclarationSyntax>()
                    .Any(p => IsBackingField(f, p)))
                .ToList();

            // Remove backing fields
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

                    // Remove references to the backing field in the property
                    return newProperty.ReplaceNodes(newProperty.DescendantNodes().OfType<IdentifierNameSyntax>(), 
                        (identifierNode, _) => identifierNode.Identifier.Text == fieldName ? 
                            SyntaxFactory.IdentifierName(newProperty.Identifier.Text) : identifierNode);
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
                return IsPotentialBackingField(fieldIdentifier, fieldName);
            });

        return backingField?.Declaration.Variables.First().Identifier.Text;
    }

    private bool IsBackingField(FieldDeclarationSyntax field, PropertyDeclarationSyntax property)
    {
        var fieldName = field.Declaration.Variables.First().Identifier.Text;
        var propertyName = property.Identifier.Text;

        return IsPotentialBackingField(fieldName, propertyName);
    }

    private bool IsPotentialBackingField(string fieldName, string propertyName)
    {
        // More robust check to determine if a field is a potential backing field for a property
        return string.Equals(fieldName.TrimStart('_'), propertyName, StringComparison.OrdinalIgnoreCase)
               || string.Equals(fieldName, $"_{propertyName}", StringComparison.OrdinalIgnoreCase)
               || string.Equals(fieldName, $"{propertyName}Field", StringComparison.OrdinalIgnoreCase);
    }
}