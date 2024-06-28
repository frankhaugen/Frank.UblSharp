using Frank.UblSharp.Resources;

namespace Frank.UblSharp.GeneratorV2;

public class Program
{
    public static void Main()
    {
        var outputDirectory = new DirectoryInfo(@"D:\frankrepos\Frank.UblSharp\Frank.UblSharp");

        var rootNamespace = "Frank.UblSharp";
        var fileLog = new List<string>();
        var generator = UblGeneratorFactory.Create(outputDirectory, rootNamespace, fileLog);
        var schemaSet = ResourcesHelper.GetXmlSchemaSet();
        generator.Generate(schemaSet);
    }
}
