namespace MapperExample.Mappings
{
    using Interfaces;
    using Models;

    public class CustomerDtoToEntityMapping : IMapping<CustomerDto, CustomerEntity>
    {
        public CustomerEntity Map(CustomerDto source)
        {
            return CustomerEntity.Create(source.FirstName, source.LastName);
        }
    }
}