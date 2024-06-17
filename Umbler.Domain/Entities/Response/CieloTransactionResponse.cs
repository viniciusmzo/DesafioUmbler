namespace Umbler.Domain.Entities.Response
{
    public class CieloTransactionResponse
    {
        public int Status { get; set; }
        public string? Tid { get; set; }
        public string? ProofOfSale { get; set; }
        public string? AuthorizationCode { get; set; }
        public string? ReturnCode { get; set; }
        public string? ReturnMessage { get; set; }
    }
}
