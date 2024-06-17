using Umbler.Domain.Entities.Request;
using Umbler.Domain.Entities.Response;

namespace Umbler.Domain.Interfaces
{
    public interface ICieloTransactionRepository
    {
        Task<CreateTransactionResponse> CreateCreditCardTransaction(CieloTransactionRequest request);
        Task<GetByPaymentIdResponse> GetByPaymentId(string paymentId);
        Task<GetByMerchantOrderIdResponse> GetByMerchantOrderId(string merchantOrderId);
        Task<CieloTransactionResponse> CaptureTransaction(string paymentId, int? amount, int? serviceTaxAmount);
        Task<CieloTransactionResponse> CancelByPaymentId(string paymentId);
    }
}
