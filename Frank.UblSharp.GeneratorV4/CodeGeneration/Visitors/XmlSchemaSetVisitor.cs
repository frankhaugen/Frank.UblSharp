using System.Xml.Schema;

namespace Frank.UblSharp.GeneratorV4.CodeGeneration.Visitors;

public class XmlSchemaSetVisitor : IAsyncVisitor<XmlSchemaSet>
{
    /// <inheritdoc />
    public async Task VisitAsync(XmlSchemaSet element)
    {
        await Task.Yield();
    }
}