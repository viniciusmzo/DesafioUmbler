namespace Umbler.Application.Dtos.Responses
{
    public class CieloTransactionResponseDto
    {
        public int Status { get; set; }
        public string? Tid { get; set; }
        public string? ProofOfSale { get; set; }
        public string? AuthorizationCode { get; set; }
        public string? ReturnCode { get; set; }
        public string? ReturnMessage { get; set; }
    }
}
