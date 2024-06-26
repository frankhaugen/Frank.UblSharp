using Frank.UblSharp.GeneratorV2.SyntaxRewriters;
using Microsoft.CodeAnalysis.CSharp;

namespace Frank.UblSharp.GeneratorV2.Visitors;

public class FileVisitor
{
    private readonly SyntaxTreeRewriter _rewriterContext = new();
    
    public void VisitFile(FileInfo file)
    {
        Console.WriteLine($"Visiting file {file.FullName}");
        var code = File.ReadAllText(file.FullName);
        var syntaxTree = CSharpSyntaxTree.ParseText(code);
        var newRoot = _rewriterContext.Rewrite(syntaxTree);
        var newCode = newRoot.ToFullString();
        File.WriteAllText(file.FullName, newCode);
    }
}