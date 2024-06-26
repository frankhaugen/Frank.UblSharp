using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace Frank.UblSharp.GeneratorV2.SyntaxRewriters;

public class RewriterContext
{
    private readonly List<CSharpSyntaxRewriter> _rewriters = [
        new AutoPropertyRewriter(),
        new PropertyCleanupRewriter()
    ];
    
    public SyntaxNode Rewrite(SyntaxNode root)
    {
        SyntaxNode result = root;
        foreach (var rewriter in _rewriters)
            result = rewriter.Visit(result);
        return result;
    }
}