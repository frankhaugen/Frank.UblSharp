using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Frank.UblSharp.GeneratorV4.CodeGeneration.Visitors;

public class CompilationUnitVisitor : IAsyncVisitor<CompilationUnitSyntax>
{
    public async Task VisitAsync(CompilationUnitSyntax element)
    {
        await Task.Yield();
    }
}