using Umbler.Domain.Validation;

namespace Umbler.Domain.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }

        public Customer() { }

        public Customer(string name, string email)
        {
            ValidateDomain(name, email);
        }

        public Customer(int id, string name, string email)
        {
            ValidateDomain(name, email);
            Id = id;
        }

        public void ValidateDomain(string name, string email) 
        {
            DomainExceptionValidation.When(name.Length <= 255, "Name exceeded number of characters. Maximum 255 characters.");
            DomainExceptionValidation.When(email.Length <= 255, "Email exceeded number of characters. Maximum 255 characters.");
        }
    }
}
