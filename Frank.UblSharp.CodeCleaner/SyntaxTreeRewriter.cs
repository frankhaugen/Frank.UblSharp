using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

internal class SyntaxTreeRewriter
{
    public void Rewrite(ref SyntaxTree syntaxTree)
    {
        var rootNode = syntaxTree.GetRoot();
        var compilation = CSharpCompilation.Create("YourCompilation")
            .AddReferences(MetadataReference.CreateFromFile(typeof(object).Assembly.Location))
            .AddSyntaxTrees(syntaxTree); // Add the SyntaxTree here

        var propertiesWithBackingFields = new PropertyExtractor(compilation.GetSemanticModel(syntaxTree)).ExtractPropertiesWithBackingFields(rootNode);

        foreach (var propertiesWithBackingField in propertiesWithBackingFields)
        {
            var rewriter = new PropertyRewriter(compilation.GetSemanticModel(syntaxTree), propertiesWithBackingField.BackingField, propertiesWithBackingField.Property);
            var newRootNode = rewriter.Visit(rootNode);

            // After doing the rewrite, refresh the syntax tree and semantic model.
            var newSyntaxTree = newRootNode.SyntaxTree;
            rootNode = newRootNode;
            compilation = compilation.ReplaceSyntaxTree(syntaxTree, newSyntaxTree);
            syntaxTree = newSyntaxTree;
        }
    }
}