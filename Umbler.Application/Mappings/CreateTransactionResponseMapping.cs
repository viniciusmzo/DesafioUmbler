using Umbler.Application.Dtos;
using Umbler.Application.Dtos.Responses;
using Umbler.Domain.Entities.Response;

namespace Umbler.Application.Mappings
{
    public static class CreateTransactionResponseMapping
    {
        public static CreateCieloTransactionDtoResponse DomainToDto(CreateTransactionResponse domainEntity) 
        {
            return new CreateCieloTransactionDtoResponse
            {
                Name = domainEntity.Customer.Name,
                MerchantOrderId = domainEntity.MerchantOrderId,
                ReturnCode = domainEntity.Payment.ReturnCode,
                PaymentId = domainEntity.Payment.PaymentId,
                ReturnMessage = domainEntity.Payment.ReturnMessage,
                Status = domainEntity.Payment.Status,
                CreditCard = new CreditCardDto 
                {
                    Brand = domainEntity.Payment.CreditCard.Brand,
                    CardNumber = domainEntity.Payment.CreditCard.CardNumber,
                    SecurityCode = domainEntity.Payment.CreditCard.ExpirationDate,
                    ExpirationDate = domainEntity.Payment.CreditCard.ExpirationDate,
                    Holder = domainEntity.Payment.CreditCard.Holder
                }
            };
        }
    }
}
