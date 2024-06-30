using System.Xml.Schema;
using Frank.UblSharp.Generation.XmlSchemaVisitors;

namespace Frank.UblSharp.Generation;

public class XmlSchemaMetaVisitor : IAsyncVisitor<XmlSchemaSet>
{
    public async Task VisitAsync(XmlSchemaSet element)
    {
        await new UblBaseDocumentVisitor().VisitAsync(element);
        await new UblCommonBasicComponentFixerVisitor().VisitAsync(element);
        await new UblCoreComponentsRenamerVisitor().VisitAsync(element);
    }
}