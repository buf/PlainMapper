namespace MapperExample.Mappings
{
    using Interfaces;
    using Models;

    public class SourceToTargetMapping : IMapping<SourceModel, TargetModel>
    {
        public TargetModel Map(SourceModel source)
        {
            return new TargetModel
            {
                SomeTargetString = source.SomeSourceString,
                SomeTargetInt = source.SomeSourceInt
            };
        }
    }
}