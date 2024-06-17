namespace Umbler.Application.Dtos
{
    public class FraudAlertDto
    {
        public string? Date { get; set; }
        public string? ReasonMessage { get; set; }
        public bool IncomingChargeback { get; set; }
    }
}
