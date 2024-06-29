namespace Frank.UblSharp.GeneratorV4.CodeGeneration.Visitors;

public interface IAsyncVisitor<in T>
{
    Task VisitAsync(T element);
}