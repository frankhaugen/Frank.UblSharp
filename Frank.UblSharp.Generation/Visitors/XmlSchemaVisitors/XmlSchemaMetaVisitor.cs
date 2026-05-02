using System.Xml.Schema;
using Frank.UblSharp.Generation.XmlSchemaVisitors;

namespace Frank.UblSharp.Generation;

public class XmlSchemaMetaVisitor : IAsyncVisitor<XmlSchemaSet>
{
    /// <summary>Runs schema fixups synchronously (preferred inside source generators).</summary>
    public void Visit(XmlSchemaSet element)
    {
        new UblBaseDocumentVisitor().Visit(element);
        new UblCommonBasicComponentFixerVisitor().Visit(element);
        new UblCoreComponentsRenamerVisitor().Visit(element);
    }

    public Task VisitAsync(XmlSchemaSet element)
    {
        Visit(element);
        return Task.CompletedTask;
    }
}