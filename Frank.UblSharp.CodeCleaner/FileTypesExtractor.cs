using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

internal class FileTypesExtractor
{
    public async Task ExtractTypesAsync(FileInfo file)
    {
        var code = await File.ReadAllTextAsync(file.FullName);
        var syntaxTree = CSharpSyntaxTree.ParseText(code);

        var types = (await syntaxTree.GetRootAsync()).DescendantNodes().OfType<TypeDeclarationSyntax>().ToList();
        
        foreach (var type in types)
        {
            var newSyntaxTree = CSharpSyntaxTree.ParseText(type.NormalizeWhitespace().ToFullString());
            var newCode = Microsoft.CodeAnalysis.Formatting.Formatter.Format(await newSyntaxTree.GetRootAsync(), new AdhocWorkspace()).ToFullString();
            await File.WriteAllTextAsync(Path.Combine(file.DirectoryName, $"{type.Identifier.ValueText}.cs"), newCode);
        }
        
        file.Delete();
    }
}