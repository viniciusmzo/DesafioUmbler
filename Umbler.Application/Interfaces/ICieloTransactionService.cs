using Umbler.Application.Dtos.Requests;
using Umbler.Application.Dtos.Responses;

namespace Umbler.Application.Interfaces
{
    public interface ICieloTransactionService
    {
        Task<CreateCieloTransactionDtoResponse> CreateCieloTransaction(CreateTransactionDtoRequest createRequest);
        Task<GetByPaymentResponseDto> GetByPaymentId(string paymentId);
        Task<CieloTransactionResponseDto> CaptureTransaction(string paymentId, int? amount, int? serviceTaxAmount);
        Task<CieloTransactionResponseDto> CancelByPaymentId(string paymentId);
    }
}
