namespace Umbler.Domain.Entities.Response
{
    public class CreateTransactionResponse
    {
        public int Id { get; set; }
        public string? MerchantOrderId { get; set; }
        public Customer? Customer { get; set; }
        public PaymentResponse? Payment { get; set; }
    }
}
