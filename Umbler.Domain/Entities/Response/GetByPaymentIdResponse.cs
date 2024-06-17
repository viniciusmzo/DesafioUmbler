namespace Umbler.Domain.Entities.Response
{
    public class GetByPaymentIdResponse
    {
        public string? MerchantOrderId { get; set; }
        public string? AcquirerOrderId { get; set; }
        public Customer? Customer { get; set; }
        public PaymentResponse? Payment { get; set; }
    }
}
