using Frank.UblSharp.GeneratorV2.SyntaxRewriters;
using Microsoft.CodeAnalysis;

namespace Frank.UblSharp.GeneratorV2.Visitors;

public class DocumentVisitor
{
    private readonly RewriterContext _rewriterContext = new();
    
    public async Task VisitAsync(Document document)
    {
        var root = await document.GetSyntaxRootAsync();
        if (root is null) return;
        var newRoot = _rewriterContext.Rewrite(root);
        if (newRoot != root) document = document.WithSyntaxRoot(newRoot);
    }
}