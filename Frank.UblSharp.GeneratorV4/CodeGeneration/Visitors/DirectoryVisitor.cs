namespace Frank.UblSharp.GeneratorV4.CodeGeneration.Visitors;

public class DirectoryVisitor : IAsyncVisitor<DirectoryInfo>
{
    public async Task VisitAsync(DirectoryInfo element)
    {
        await Task.Yield();
    }
}