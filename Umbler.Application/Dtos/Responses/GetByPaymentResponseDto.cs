namespace Umbler.Application.Dtos.Responses
{
    public class GetByPaymentResponseDto
    {
        public string? MerchantOrderId { get; set; }
        public string? AcquirerOrderId { get; set; }
        public string? CustomerName { get; set; }
        public PaymentResponseDto? Payment { get; set; }
    }
}
