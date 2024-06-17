namespace Umbler.Application.Dtos.Requests
{
    public class CreateTransactionDtoRequest
    {
        public string? MerchantOrderId { get; set; }
        public CustomerDto? Customer { get; set; }
        public PaymentDto? Payment { get; set; }
    }
}
