using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Schema;
using Frank.UblSharp.Resources;

namespace Frank.UblSharp.Generator
{
    public static class Canary
    {
        public static string Run()
        {
            var stringBuilder = new StringBuilder();
            var schemaSet = ResourcesHelper.GetXmlSchemaSet();
            
            var generator = new UblGenerator();
            var options = new UblGeneratorOptions
            {
                OutputPath = Path.Combine(AppContext.BaseDirectory, @"..\..\..\..\..\..\.generated"),
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
        
            return stringBuilder.ToString();
        }
    }
}