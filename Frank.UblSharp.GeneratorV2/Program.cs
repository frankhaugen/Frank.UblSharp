using Frank.UblSharp.GeneratorV2.Visitors;
using Frank.UblSharp.Resources;
using XmlSchemaClassGenerator;

namespace Frank.UblSharp.GeneratorV2;

public class Program
{
    public static async Task Main()
    {
        var outputDirectory = new DirectoryInfo(@"D:\frankrepos\Frank.UblSharp\Frank.UblSharp");

        // GenerateFiles(outputDirectory);

        var file = new FileInfo(@"D:\frankrepos\Frank.UblSharp\Frank.UblSharp\Frank.UblSharp.ApplicationResponse\ApplicationResponseType.cs");
        var before = await File.ReadAllTextAsync(file.FullName);
        var fileVisitor = new FileVisitor();
        fileVisitor.VisitFile(file);
        var after = await File.ReadAllTextAsync(file.FullName);
        
        Console.WriteLine(after);
    }

    private static void GenerateFiles(DirectoryInfo outputDirectory)
    {
        var fileLog = new List<string>();
        var schemaSet = ResourcesHelper.GetXmlSchemaSet();
        var converter = UblGeneratorFactory.Create(outputDirectory, "Frank.UblSharp", fileLog);

        converter.GenerateNullables = true;
        converter.CollectionSettersMode = CollectionSettersMode.PublicWithoutConstructorInitialization;

        converter.Generate(schemaSet);

        foreach (var log in fileLog) Console.Error.WriteLine(log);
    }
}