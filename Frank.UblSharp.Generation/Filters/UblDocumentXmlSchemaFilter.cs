using System.Xml.Schema;

namespace Frank.UblSharp.Generation;

public class UblMainDocumentXmlSchemaFilter : IFilter<XmlSchemaSet>
{
    public XmlSchemaSet Filter(XmlSchemaSet element)
    {
        var schemaSet = new XmlSchemaSet();
        foreach (var schema in element.Schemas().Cast<XmlSchema>())
            if (schema.TargetNamespace?.StartsWith("urn:oasis:names:specification:ubl:schema:xsd:") == true)
                schemaSet.Add(schema);
        return schemaSet;
    }
}