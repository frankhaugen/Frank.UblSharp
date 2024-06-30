using System.CodeDom;
using System.Text;
using Frank.UblSharp.Resources;
using XmlSchemaClassGenerator;

namespace Frank.UblSharp.GeneratorV2;

public class Program
{
    public static void Main()
    {
        var outputDirectory = new DirectoryInfo(@"D:\frankrepos\Frank.UblSharp\Frank.UblSharp");
        foreach (var file in outputDirectory.GetFiles("*.cs", SearchOption.TopDirectoryOnly)) file.Delete();
        foreach (var directory in outputDirectory.GetDirectories()) directory.Delete(true);

        var generator = UblGeneratorFactory.Create(outputDirectory, Console.WriteLine, new CodeOutputWriter(outputDirectory));
        var schemaSet = ResourcesHelper.GetXmlSchemaSet();
        
        generator.Generate(schemaSet);
        
        // var files = outputDirectory.GetFiles("*.cs", SearchOption.TopDirectoryOnly);
        // foreach (var file in files)
        // {
        //     var find1 = "{ get; set; };";
        //     var replace1 = "{ get; set; }";
        //     var find2 = "    };";
        //     var replace2 = "    }";
        //     var text = File.ReadAllText(file.FullName);
        //     text = text.Replace(find1, replace1).Replace(find2, replace2);
        //     File.WriteAllText(file.FullName, text);
        // }
    }
}

public class CodeOutputWriter : OutputWriter
{
    private readonly DirectoryInfo _outputDirectory;
    
    public CodeOutputWriter(DirectoryInfo outputDirectory)
    {
        _outputDirectory = outputDirectory;
    }
    
    /// <inheritdoc />
    public override void Write(CodeNamespace cn)
    {
        var outputFileName = Path.Combine(_outputDirectory.FullName, cn.Name + ".cs");
        var codeBuilder = new StringBuilder();
        using var writer = new StringWriter(codeBuilder);
        using var codeProvider = Provider;
        codeProvider.GenerateCodeFromNamespace(cn, writer, base.Options);
        
        var code = codeBuilder.ToString();
        code = code.Replace("System.CodeDom.Compiler;", "System.CodeDom.Compiler;\nusing System.CodeDom.Compiler;");
        code = code.Replace("System.CodeDom;", "System.CodeDom;\nusing System.CodeDom;");
        code = code.Replace("System;", "System;\nusing System;");
        
        File.WriteAllText(outputFileName, code);
    }
}
