namespace Umbler.Domain.Entities
{
    public class Chargeback
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public string? CaseNumber { get; set; }
        public string? Date { get; set; }
        public string? ReasonCode { get; set; }
        public string? ReasonMessage { get; set; }
        public string? Status { get; set; }
        public string? RawData { get; set; }
    }
}
