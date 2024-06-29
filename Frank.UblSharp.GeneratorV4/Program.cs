using Frank.UblSharp.Resources;

namespace Frank.UblSharp.GeneratorV4;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        var options = new UblGeneratorOptions
        {
            OutputDirectory = new DirectoryInfo("../../../../Frank.UblSharp"),
            GenerateCommonFiles = true,
            CleanOutputDirectoryBeforeGeneration = true,
            Namespace = "Frank.UblSharp"
        };
        
        var codeGenerator = new UblGenerator();

        var schemaSet = ResourcesHelper.GetXmlSchemaSet();
        
        await codeGenerator.Generate(schemaSet, options);
    }
}