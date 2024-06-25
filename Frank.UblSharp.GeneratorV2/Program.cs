using Frank.UblSharp.GeneratorV2.Visitors;
using Frank.UblSharp.Resources;
using Microsoft.CodeAnalysis.MSBuild;
using XmlSchemaClassGenerator;

namespace Frank.UblSharp.GeneratorV2;

public class Program
{
    public static async Task Main()
    {
        var outputDirectory = new DirectoryInfo(@"D:\frankrepos\Frank.UblSharp\Frank.UblSharp");
        
        // GenerateFiles(outputDirectory);
        
        new DirectoryVisitor().VisitDirectory(outputDirectory);
    }

    private static void GenerateFiles(DirectoryInfo outputDirectory)
    {
        var fileLog = new List<string>();
        var schemaSet = ResourcesHelper.GetXmlSchemaSet();
        var converter = UblGeneratorFactory.Create(outputDirectory, "Frank.UblSharp", fileLog);

        converter.GenerateNullables = true;
        converter.CollectionSettersMode = CollectionSettersMode.PublicWithoutConstructorInitialization;
        
        converter.Generate(schemaSet);
        
        foreach (var log in fileLog)
        {
            Console.Error.WriteLine(log);
        }
    }
}