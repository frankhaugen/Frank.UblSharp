using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Frank.UblSharp.GeneratorV4.CodeGeneration.Visitors;

public class NamespaceVisitor : IAsyncVisitor<NamespaceDeclarationSyntax>
{
    public async Task VisitAsync(NamespaceDeclarationSyntax element)
    {
        await Task.Yield();
    }
}