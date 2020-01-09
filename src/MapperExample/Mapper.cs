namespace MapperExample
{
    using System;
    using Exceptions;
    using Interfaces;

    public class Mapper : IMapper
    {
        private readonly IServiceProvider _serviceProvider;

        public Mapper(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public TTarget Map<TSource, TTarget>(TSource source)
        {
            var mapping = _serviceProvider.GetService(typeof(IMapping<TSource, TTarget>)) as IMapping<TSource, TTarget>;
            if (mapping == null)
            {
                throw new MissingMappingException(typeof(TSource), typeof(TTarget));
            }

            return mapping.Map(source);
        }
    }
}