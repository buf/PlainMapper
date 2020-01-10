namespace SimpleMapper.Extensions
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Interfaces;

    public static class AssemblyExtensions
    {
        public static IEnumerable<MappingType> GetMappings(params Assembly[] assemblies)
        {
            var mapperType = typeof(IMapping<,>);
            return assemblies.SelectMany(x => x.GetTypes())
                .Where(x => x.GetInterfaces().Any(i => i.IsGenericType && i.Name == mapperType.Name))
                .Where(x => x.IsClass && !x.IsAbstract)
                .Select(x => new MappingType(x, x.GetInterface(mapperType.Name)));
        }
    }
}