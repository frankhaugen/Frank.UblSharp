using System.Text;
using System.Xml.Schema;
using Frank.UblSharp.Resources;

namespace Frank.UblSharp.Generator;

public static class Canary
{
    public static string Run()
    {
        var schemaSet = ResourcesHelper.GetXmlSchemaSet();
        
        var stringBuilder = new StringBuilder();
        
        foreach (var schema in schemaSet.Schemas().OfType<XmlSchema>())
        {
            stringBuilder.AppendLine(schema.Id);
        }
        
        return stringBuilder.ToString();
    }
}