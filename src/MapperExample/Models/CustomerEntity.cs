namespace MapperExample.Models
{
    public class CustomerEntity
    {
        private CustomerEntity(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; }

        public string LastName { get; }

        public string FullName => $"{FirstName} {LastName}".Trim();

        public static CustomerEntity Create(string firstName, string lastName)
        {
            return new CustomerEntity(firstName, lastName);
        }
    }
}