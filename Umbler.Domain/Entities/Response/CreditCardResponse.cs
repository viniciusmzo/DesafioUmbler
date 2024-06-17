namespace Umbler.Domain.Entities.Response
{
    public class CreditCardResponse : CreditCard
    {
        public string? PaymentAccountReference { get; set; }
    }
}
