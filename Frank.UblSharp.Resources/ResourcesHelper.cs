using System.Xml.Schema;

namespace Frank.UblSharp.Resources
{
    public static class ResourcesHelper
    {
        public static XmlSchemaSet GetXmlSchemaSet() => AdditionalResources.GetXmlSchemaSet();
    }
}