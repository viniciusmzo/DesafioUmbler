namespace Umbler.Application.Dtos
{
    public class PaymentDto
    {
        public string? Type { get; set; }
        public int Amount { get; set; }
        public int Installments { get; set; }
        public bool Capture { get; set; }
        public string? SoftDescriptor { get; set; }
        public CreditCardDto? CreditCard { get; set; }
    }
}
