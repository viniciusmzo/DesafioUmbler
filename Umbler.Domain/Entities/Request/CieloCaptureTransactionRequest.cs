namespace Umbler.Domain.Entities.Request
{
    public class CieloCaptureTransactionRequest
    {
        public string? PaymentId { get; set; }
        public int? Amount { get; set; }
        public int? ServiceTaxAmount { get; set; }
    }
}
