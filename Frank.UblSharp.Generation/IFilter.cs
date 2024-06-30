namespace Frank.UblSharp.Generation;

public interface IFilter<T>
{
    T Filter(T element);
}