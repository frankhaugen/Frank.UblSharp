using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace Frank.UblSharp.GeneratorV2.SyntaxRewriters;

public class SyntaxTreeRewriter
{
    public SyntaxNode Rewrite(SyntaxTree syntaxTree)
    {
        var root = syntaxTree.GetRoot();
        var compilation = CSharpCompilation.Create("YourCompilation")
            .AddReferences(MetadataReference.CreateFromFile(typeof(object).Assembly.Location))
            .AddSyntaxTrees(syntaxTree);
        var semanticModel = compilation.GetSemanticModel(syntaxTree);
        SyntaxNode result = root;
        result = new AutoPropertyRewriter(semanticModel).Visit(result);
        return result;
    }
}