﻿using Umbler.Domain.Entities;

namespace Umbler.Application.Dtos.Responses
{
    public class PaymentResponseDto : PaymentDto
    {
        public bool TryAutomaticCancellation { get; set; }
        public string? ProofOfSale { get; set; }
        public string? Tid { get; set; }
        public string? AuthorizationCode { get; set; }
        public string? PaymentId { get; set; }
        public int CapturedAmount { get; set; }
        public int Status { get; set; }
        public string? ReturnCode { get; set; }
        public string? ReturnMessage { get; set; }
        public string? MerchantAdviceCode { get; set; }
        public List<ChargebackDto>? Chargebacks { get; set; }
        public FraudAlertDto? FraudAlert { get; set; }
        public string? ReceivedDate { get; set; }
        public string? CapturedDate { get; set; }
        public int VoidedAmount { get; set; }
        public string? VoidedDate { get; set; }
    }
}
