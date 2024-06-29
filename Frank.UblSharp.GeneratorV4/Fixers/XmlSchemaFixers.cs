using System.Xml.Schema;
using Frank.UblSharp.GeneratorV4.CodeGeneration.Visitors.XmlSchemaVisitors;

namespace Frank.UblSharp.GeneratorV4.Fixers;

public static class XmlSchemaFixers
{
    public static async Task FixXmlSchemaAsync(XmlSchemaSet xmlSchemaSet)
    {
        await new UblBaseDocumentVisitor().VisitAsync(xmlSchemaSet);
        await new UblCommonBasicComponentFixerVisitor().VisitAsync(xmlSchemaSet);
        await new UblCoreComponentsRenamerVisitor().VisitAsync(xmlSchemaSet);
    }
}