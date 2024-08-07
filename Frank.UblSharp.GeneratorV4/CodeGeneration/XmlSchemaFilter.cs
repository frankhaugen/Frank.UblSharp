﻿using System.Xml.Schema;

namespace Frank.UblSharp.GeneratorV4.CodeGeneration;

public interface IFilter<T>
{
    T Filter(T element);
}

public class UblDocumentXmlSchemaFilter : IFilter<XmlSchemaSet>
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