using Umbler.Application.Dtos.Responses;
using Umbler.Domain.Entities.Response;

namespace Umbler.Application.Mappings
{
    public static class GetByPaymentIdResponseMapping
    {
        public static GetByPaymentResponseDto DomaintToDto(GetByPaymentIdResponse domainResponse) 
        {
            return new GetByPaymentResponseDto
            {
                AcquirerOrderId = domainResponse.AcquirerOrderId,
                MerchantOrderId = domainResponse.MerchantOrderId,
                CustomerName = domainResponse.Customer.Name,
                Payment = new PaymentResponseDto 
                {
                    Amount = domainResponse.Payment.Amount,
                    Capture = domainResponse.Payment.Capture,
                    Installments = domainResponse.Payment.Installments,
                    SoftDescriptor = domainResponse.Payment.SoftDescriptor,
                    Type = domainResponse.Payment.Type,
                    CreditCard = new Dtos.CreditCardDto
                    {
                        Brand = domainResponse.Payment.CreditCard.Brand,
                        CardNumber = domainResponse.Payment.CreditCard.CardNumber,
                        ExpirationDate = domainResponse.Payment.CreditCard.ExpirationDate,
                        Holder = domainResponse.Payment.CreditCard.Holder,
                        SecurityCode = domainResponse.Payment.CreditCard.SecurityCode
                    }
                }
            };
        }
    }
}
