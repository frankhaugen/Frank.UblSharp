using Frank.UblSharp.GeneratorV2.SyntaxRewriters;
using Microsoft.CodeAnalysis.CSharp;

namespace Frank.UblSharp.GeneratorV2.Visitors;

public class FileVisitor
{
    public void VisitFile(FileInfo file)
    {
        var code = File.ReadAllText(file.FullName);
        var tree = CSharpSyntaxTree.ParseText(code);
        var root = tree.GetRoot();
        var newRoot = new PropertyRewriter().Visit(root);
        newRoot = new FieldRewriter().Visit(newRoot);
        var newCode = newRoot.ToFullString();
        File.WriteAllText(file.FullName, newCode);
    }
}