namespace Frank.UblSharp.GeneratorV4.CodeGeneration.Visitors;

public class FileVisitor : IAsyncVisitor<FileInfo>
{
    public async Task VisitAsync(FileInfo element)
    {
        await Task.Yield();
    }
}