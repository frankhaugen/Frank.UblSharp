using System.CodeDom;
using Frank.UblSharp.Resources;
using XmlSchemaClassGenerator;

namespace Frank.UblSharp.GeneratorV2;

public class Program
{
    public static void Main()
    {
        var outputDirectory = new DirectoryInfo(@"D:\frankrepos\Frank.UblSharp\Frank.UblSharp");

        var rootNamespace = "Frank.UblSharp";
        var fileLog = new List<string>();
        var generator = UblGeneratorFactory.Create(outputDirectory, rootNamespace, fileLog, new MyOutputWriter());
        var schemaSet = ResourcesHelper.GetXmlSchemaSet();
        generator.Generate(schemaSet);
        
        var files = outputDirectory.GetFiles("*.cs", SearchOption.TopDirectoryOnly);
        foreach (var file in files)
        {
            var find1 = "{ get; set; };";
            var replace1 = "{ get; set; }";
            var find2 = "    };";
            var replace2 = "    }";
            var text = File.ReadAllText(file.FullName);
            text = text.Replace(find1, replace1).Replace(find2, replace2);
            File.WriteAllText(file.FullName, text);
        }
    }
}

public class MyOutputWriter : OutputWriter
{
    /// <inheritdoc />
    public override void Write(CodeNamespace cn)
    {
        var outputDirectory = new DirectoryInfo(@"D:\frankrepos\Frank.UblSharp\Frank.UblSharp");
        Console.WriteLine(cn.Name);
        var outputFileName = Path.Combine(outputDirectory.FullName, cn.Name + ".cs");
        using var writer = new StreamWriter(outputFileName);
        using var codeProvider = Provider;
        
        codeProvider.GenerateCodeFromNamespace(cn, writer, base.Options);
    }
}
