using System.Xml.Schema;
using Frank.UblSharp.GeneratorV4.CodeGeneration;
using Frank.UblSharp.GeneratorV4.Experimental;
using Frank.UblSharp.GeneratorV4.Fixers;
using Microsoft.CodeAnalysis;

namespace Frank.UblSharp.GeneratorV4;

public class UblGenerator
{
    public async Task Generate(XmlSchemaSet schemaSet, UblGeneratorOptions options)
    {
        Console.WriteLine("Validating options...");

        var schemasToGenerate = options.GenerateCommonFiles
            ? schemaSet
            : new UblDocumentXmlSchemaFilter().Filter(schemaSet);

        await XmlSchemaFixers.FixXmlSchemaAsync(schemasToGenerate);

        schemasToGenerate.Compile();

        var codeGenerationResult = new XsdToCSharpGenerator(schemasToGenerate).Generate();

        Console.WriteLine(codeGenerationResult.ClassDeclarations.Count);

        if (options.CleanOutputDirectoryBeforeGeneration)
        {
            Console.WriteLine("Cleaning output directory...");
            foreach (var file in options.OutputDirectory.EnumerateFiles("*.cs")) // "*.cs
                file.Delete();
        }

        foreach (var classDefinition in codeGenerationResult.ClassDeclarations)
        {
            var filePath = Path.Combine(options.OutputDirectory.FullName, classDefinition.ClassName + ".cs");
            var classDeclaration = classDefinition.ClassDeclaration;
            await File.WriteAllTextAsync(filePath, classDeclaration.NormalizeWhitespace().ToFullString());
        }
    }
}