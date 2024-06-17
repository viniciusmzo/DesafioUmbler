namespace Umbler.Domain.Entities.Request
{
    public class CieloTransactionRequest
    {
        public int Id { get; set; }
        public string? MerchantOrderId { get; set; }
        public Customer? Customer { get; set; }
        public Payment? Payment { get; set; }
    }
}
