using Umbler.Domain.Validation;

namespace Umbler.Domain.Entities
{
    public class CreditCard
    {
        public int Id { get; set; }
        public string? CardNumber { get; set; }
        public string? Holder { get; set; }
        public string? ExpirationDate { get; set; }
        public string? SecurityCode { get; set; }
        public string? Brand { get; set; }

        public CreditCard() { }

        public CreditCard(string cardNumber, string holder, string expirationDate, string securityCode, string brand) 
        {
            ValidateDomain(cardNumber, holder, expirationDate, securityCode, brand);
        }

        public CreditCard(int id, string cardNumber, string holder, string expirationDate, string securityCode, string brand)
        {
            ValidateDomain(cardNumber, holder, expirationDate, securityCode, brand);
            Id = id;
        }

        public void ValidateDomain(string cardNumber, string holder, string expirationDate, string securityCode, string brand) 
        {
            DomainExceptionValidation.When(string.IsNullOrWhiteSpace(cardNumber), "Invalid card number. Card number is required.");
            DomainExceptionValidation.When(cardNumber.Length >= 13, "The minimum 13 characters for the card number has not been reached.");
            DomainExceptionValidation.When(cardNumber.Length <= 16, "Card number exceeded number of characters. Maximum 16 characters.");

            DomainExceptionValidation.When(holder.Length <= 25, "Holder exceeded number of characters. Maximum 25 characters.");

            DomainExceptionValidation.When(string.IsNullOrWhiteSpace(expirationDate), "Invalid expiration date. Expiration date is required.");
            DomainExceptionValidation.When(expirationDate.Length <= 7, "Expiration date exceeded number of characters. Maximum 7 characters.");

            DomainExceptionValidation.When(string.IsNullOrWhiteSpace(brand), "Invalid brand. Brand is required.");
            DomainExceptionValidation.When(expirationDate.Length <= 10, "Brand exceeded number of characters. Maximum 10 characters.");

            CardNumber = cardNumber;
            Holder = holder;
            ExpirationDate = expirationDate;
            SecurityCode = securityCode;
            Brand = brand;
        }
    }
}
