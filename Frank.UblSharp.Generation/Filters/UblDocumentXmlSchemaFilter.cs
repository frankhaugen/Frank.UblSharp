using System;
using System.Xml.Schema;

namespace Frank.UblSharp.Generation;

public class UblMainDocumentXmlSchemaFilter : IFilter<XmlSchemaSet>
{
    public XmlSchemaSet Filter(XmlSchemaSet element)
    {
        var schemaSet = new XmlSchemaSet();
        foreach (var schema in element.Schemas().Cast<XmlSchema>())
        {
            if (IncludeSchema(schema.TargetNamespace))
                schemaSet.Add(schema);
        }

        return schemaSet;
    }

    private static bool IncludeSchema(string? targetNamespace)
    {
        if (targetNamespace is null)
            return false;

        // OASIS UBL document and common XSDs
        if (targetNamespace.StartsWith("urn:oasis:names:specification:ubl:schema:xsd:", StringComparison.Ordinal))
            return true;

        // UN/CEFACT CCT + documentation (required for UDT/CBC restrictions)
        if (targetNamespace.StartsWith("urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2", StringComparison.Ordinal))
            return true;
        if (targetNamespace.StartsWith("urn:un:unece:uncefact:documentation:2", StringComparison.Ordinal))
            return true;

        // XMLDSig + XAdES (signature aggregates import these)
        if (targetNamespace.StartsWith("http://www.w3.org/2000/09/xmldsig#", StringComparison.Ordinal))
            return true;
        if (targetNamespace.StartsWith("http://uri.etsi.org/01903/", StringComparison.Ordinal))
            return true;

        return false;
    }
}