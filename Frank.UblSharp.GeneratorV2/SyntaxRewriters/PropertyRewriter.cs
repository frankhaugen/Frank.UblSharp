using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Frank.UblSharp.GeneratorV2.SyntaxRewriters;

    public class PropertyRewriter : CSharpSyntaxRewriter
    {
        public override SyntaxNode VisitPropertyDeclaration(PropertyDeclarationSyntax node)
        {
            Console.WriteLine($"Property: {node.Identifier.Text}");
            
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
                        return node.WithoutLeadingTrivia().WithTrailingTrivia(SyntaxFactory.Whitespace(Environment.NewLine))
                            .WithAccessorList(SyntaxFactory.AccessorList(SyntaxFactory.List(new[]
                            {
                                SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                                    .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)),
                                SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration)
                                    .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken))
                            })))
                            .WithTriviaFrom(node);
                    }
                }
            }

            return base.VisitPropertyDeclaration(node);
        }

        private string? GetBackingField(PropertyDeclarationSyntax property)
        {
            var classDeclaration = property.Ancestors().OfType<ClassDeclarationSyntax>().FirstOrDefault();
            if (classDeclaration == null) return null;

            var fieldName = property.Identifier.Text;
            var backingField = classDeclaration.Members
                .OfType<FieldDeclarationSyntax>()
                .FirstOrDefault(f => f.Declaration.Variables.Any(v => v.Identifier.Text.Contains(fieldName, StringComparison.OrdinalIgnoreCase)));

            return backingField?.Declaration.Variables.First().Identifier.Text;
        }
    }
