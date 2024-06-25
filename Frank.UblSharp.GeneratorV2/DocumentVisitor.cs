using Frank.UblSharp.GeneratorV2.SyntaxRewriters;
using Microsoft.CodeAnalysis;

namespace Frank.UblSharp.GeneratorV2;

public class DocumentVisitor
{
    public async Task VisitAsync(Document document)
    {
        var root = await document.GetSyntaxRootAsync();
        if (root is null) return;

        var newRoot = new PropertyRewriter().Visit(root);
        if (newRoot != root) document = document.WithSyntaxRoot(newRoot);
    }
}