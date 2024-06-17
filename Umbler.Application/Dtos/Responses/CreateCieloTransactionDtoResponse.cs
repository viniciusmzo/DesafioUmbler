namespace Umbler.Application.Dtos.Responses
{
    public class CreateCieloTransactionDtoResponse
    {
        public string? MerchantOrderId { get; set; }
        public string? Name { get; set; }
        public string? PaymentId { get; set; }
        public int Status { get; set; }
        public string? ReturnCode { get; set; }
        public string? ReturnMessage { get; set; }
        public CreditCardDto? CreditCard { get; set; }
    }
}
