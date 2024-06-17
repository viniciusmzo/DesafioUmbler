using Umbler.Domain.Validation;

namespace Umbler.Domain.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public string? Type { get; set; }
        public int Amount { get; set; }
        public int Installments { get; set; }
        public bool Capture { get; set; }
        public string? SoftDescriptor { get; set; }
        public CreditCard? CreditCard { get; set; }

        public Payment() { }

        public Payment(int installments, bool capture, string softDescriptor, string type, int amount) 
        {
            ValidateDomain( installments, capture, softDescriptor, type, amount);
        }

        public Payment(int id, int installments, bool capture, string softDescriptor, string type, int amount)
        {
            ValidateDomain(installments, capture, softDescriptor, type, amount);
            Id = id;
        }

        public void ValidateDomain(int installments, bool capture, string softDescriptor, string type, int amount) 
        {
            DomainExceptionValidation.When(installments >= 0, "The installments value must be greater than or equal to 0.");
            DomainExceptionValidation.When(installments <= 99, "The installments value must be less than or equal to 99.");

            DomainExceptionValidation.When(softDescriptor.Length <= 13, "SoftDescriptor exceeded number of characters. Maximum 13 characters.");

            DomainExceptionValidation.When(string.IsNullOrWhiteSpace(type), "Invalid type. Type is required.");
            DomainExceptionValidation.When(type.Length >= 0, "Type exceeded number of characters. Maximum 100 characters.");
            DomainExceptionValidation.When(type.Length <= 100, "Type exceeded number of characters. Maximum 100 characters.");

            DomainExceptionValidation.When(amount < 0, "The amount value must be greater than 0.");
            
            Installments = installments;
            Capture = capture;
            Type = type;
            Amount = amount;
            Capture = capture;
        }
    }
}
