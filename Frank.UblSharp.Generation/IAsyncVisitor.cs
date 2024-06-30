namespace Frank.UblSharp.Generation;

public interface IAsyncVisitor<in T>
{
    Task VisitAsync(T element);
}