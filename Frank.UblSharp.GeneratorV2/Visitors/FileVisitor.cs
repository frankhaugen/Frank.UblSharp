using Frank.UblSharp.GeneratorV2.SyntaxRewriters;
using Microsoft.CodeAnalysis.CSharp;

namespace Frank.UblSharp.GeneratorV2.Visitors;

public class FileVisitor
{
    private readonly RewriterContext _rewriterContext = new();
    
    public void VisitFile(FileInfo file)
    {
        var code = File.ReadAllText(file.FullName);
        var tree = CSharpSyntaxTree.ParseText(code);
        var root = tree.GetRoot();
        var newRoot = _rewriterContext.Rewrite(root);
        var newCode = newRoot.ToFullString();
        File.WriteAllText(file.FullName, newCode);
    }
}