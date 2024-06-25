using System;
using System.IO;
using System.Text;
using System.Xml.Schema;
using Frank.UblSharp.Resources;

namespace Frank.UblSharp.Generator
{
    public class Program
    {
        public static void Main()
        {
            var stringBuilder = new StringBuilder();
            var schemaSet = ResourcesHelper.GetXmlSchemaSet();
            
            var generator = new UblGenerator();
            var options = new UblGeneratorOptions
            {
                OutputPath = Path.Combine(AppContext.BaseDirectory, @"..\..\..\..\Frank.UblSharp"),
                Namespace = "Frank.UblSharp",
                UblSharpNamespace = "Frank.UblSharp",
                GenerateCommonFiles = true,
                ValidationHandler = (sender, e) =>
                {
                    stringBuilder.AppendLine($"{e.Severity}: {e.Message}");
                    if (e.Severity == XmlSeverityType.Error)
                    {
                        throw e.Exception;
                    }
                },
            };
            
            generator.Generate(schemaSet, options);
        
            var result = stringBuilder.ToString();
            Console.WriteLine(result);
        }
    }
}