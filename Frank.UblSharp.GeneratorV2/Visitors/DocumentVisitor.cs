using Frank.UblSharp.GeneratorV2.SyntaxRewriters;
using Microsoft.CodeAnalysis;

namespace Frank.UblSharp.GeneratorV2.Visitors;

public class DocumentVisitor
{
    private readonly SyntaxTreeRewriter _syntaxTreeRewriter = new();
    
    public async Task VisitAsync(Document document)
    {
        var root = await document.GetSyntaxRootAsync();
        if (root is null) return;
        var newRoot = _syntaxTreeRewriter.Rewrite(root.SyntaxTree);
        if (newRoot != root) document = document.WithSyntaxRoot(newRoot);
    }
}