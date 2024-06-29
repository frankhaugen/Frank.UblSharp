using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Frank.UblSharp.GeneratorV4.CodeGeneration.Visitors;

public class TypeDeclarationVisitor : IAsyncVisitor<TypeDeclarationSyntax>
{
    public async Task VisitAsync(TypeDeclarationSyntax element)
    {
        await Task.Yield();
    }
}