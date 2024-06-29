using System.Xml.Schema;
using System.Xml.Serialization;

namespace Frank.UblSharp.GeneratorV4.Extensions;

public static class XmlSchemaSetExtensions
{
    public static XmlSchemas GetSchemas(this XmlSchemaSet xmlSchemaSet)
    {
        var schemas = new XmlSchemas();
        foreach (var schema in xmlSchemaSet.Schemas().Cast<XmlSchema>())
            schemas.Add(schema);
        return schemas;
    }
}