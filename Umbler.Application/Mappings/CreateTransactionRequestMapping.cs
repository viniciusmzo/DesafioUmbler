using Umbler.Application.Dtos.Requests;
using Umbler.Domain.Entities.Request;

namespace Umbler.Application.Mappings
{
    public static class CreateTransactionRequestMapping
    {
        public static CieloTransactionRequest DtoToDomain(CreateTransactionDtoRequest requestDto) 
        {
            return new CieloTransactionRequest
            {
                MerchantOrderId = requestDto.MerchantOrderId,
                Customer = new Domain.Entities.Customer
                {
                    Name = requestDto.Customer.Name,
                    Email = requestDto.Customer.Email
                },
                Payment = new Domain.Entities.Payment 
                {
                    Amount = requestDto.Payment.Amount,
                    Capture = requestDto.Payment.Capture,
                    Installments = requestDto.Payment.Installments,
                    SoftDescriptor = requestDto.Payment.SoftDescriptor,
                    Type = requestDto.Payment.Type,
                    CreditCard = new Domain.Entities.CreditCard 
                    {
                        Brand = requestDto.Payment.CreditCard.Brand,
                        CardNumber = requestDto.Payment.CreditCard.CardNumber,
                        ExpirationDate = requestDto.Payment.CreditCard.ExpirationDate,
                        Holder = requestDto.Payment.CreditCard.Holder,
                        SecurityCode = requestDto.Payment.CreditCard.SecurityCode,
                    }
                }
            };
        }
    }
}
