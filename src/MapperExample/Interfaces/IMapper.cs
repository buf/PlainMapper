namespace MapperExample.Interfaces
{
    public interface IMapper
    {
        TTarget Map<TSource, TTarget>(TSource source);
    }
}