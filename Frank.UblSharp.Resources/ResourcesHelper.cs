using System.Xml.Schema;

namespace Frank.UblSharp.Resources;

public static class ResourcesHelper
{
    public static XmlSchemaSet GetXmlSchemaSet()
    {
        return AdditionalResources.GetXmlSchemaSet();
        
        var schemaSet = new XmlSchemaSet();
        
        return schemaSet;
    }
}