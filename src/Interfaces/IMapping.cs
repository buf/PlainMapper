namespace PlainMapper.Interfaces
{
    public interface IMapping<in TSource, out TTarget>
    {
        TTarget Map(TSource source);
    }
}