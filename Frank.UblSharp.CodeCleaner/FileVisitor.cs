using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

internal class FileVisitor
{
    public void VisitFile(FileInfo file)
    {
        Console.WriteLine($"Visiting file {file.Name}");
        var code = File.ReadAllText(file.FullName);
        var syntaxTree = CSharpSyntaxTree.ParseText(code);

        var rewriter = new SyntaxTreeRewriter();
        rewriter.Rewrite(ref syntaxTree);

        var newCode = Microsoft.CodeAnalysis.Formatting.Formatter.Format(syntaxTree.GetRoot(), new AdhocWorkspace()).ToFullString();

        File.WriteAllText(file.FullName, newCode);
    }
}