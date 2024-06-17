namespace Umbler.Domain.Entities
{
    public class FraudAlert
    {
        public int Id { get; set; }
        public string? Date { get; set; }
        public string? ReasonMessage { get; set; }
        public bool IncomingChargeback { get; set; }
    }
}
