using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Frank.UblSharp.GeneratorV4.CodeGeneration.Visitors;

public class MemberDeclarationVisitor : IAsyncVisitor<MemberDeclarationSyntax>
{
    public async Task VisitAsync(MemberDeclarationSyntax element)
    {
        await Task.Yield();
    }
}