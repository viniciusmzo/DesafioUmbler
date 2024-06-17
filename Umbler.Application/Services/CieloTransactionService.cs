using AutoMapper;
using System.ComponentModel.DataAnnotations;
using Umbler.Application.Dtos.Requests;
using Umbler.Application.Dtos.Responses;
using Umbler.Application.Interfaces;
using Umbler.Application.Mappings;
using Umbler.Domain.Interfaces;

namespace Umbler.Application.Services
{
    public class CieloTransactionService : ICieloTransactionService
    {
        private readonly ICieloTransactionRepository _cieloRepository;
        private readonly IMapper _mapper;

        public CieloTransactionService(ICieloTransactionRepository cieloRepository, IMapper mapper)
        {
            _cieloRepository = cieloRepository;
            _mapper = mapper;
        }

        public async Task<CreateCieloTransactionDtoResponse> CreateCieloTransaction(CreateTransactionDtoRequest requestDto)
        {
            var requestEntity = CreateTransactionRequestMapping.DtoToDomain(requestDto);

            try
            {
                var responseCieloRepository = await _cieloRepository.CreateCreditCardTransaction(requestEntity);

                return CreateTransactionResponseMapping.DomainToDto(responseCieloRepository);
            }
            catch (HttpRequestException ex)
            {
                throw new HttpRequestException("There was a problem communicating with the Cielo service. Please try again later.", ex);
            }
            catch (ValidationException ex) 
            {
                throw new ValidationException("The provided transaction details are invalid.", ex);
            }
            catch(Exception ex) 
            {
                throw new Exception("An unexpected error occurred. Please try again later.", ex);
            }
        }

        public async Task<GetByPaymentResponseDto> GetByPaymentId(string paymentId)
        {
            try
            {
                var responseCieloRepository = await _cieloRepository.GetByPaymentId(paymentId);

                if (responseCieloRepository == null) 
                {
                    return null;
                }

                return GetByPaymentIdResponseMapping.DomaintToDto(responseCieloRepository);
            }
            catch (HttpRequestException ex)
            {
                throw new HttpRequestException("There was a problem communicating with the Cielo service. Please try again later.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("An unexpected error occurred. Please try again later.", ex);
            }
        }

        public async Task<CieloTransactionResponseDto> CancelByPaymentId(string paymentId)
        {
            try
            {
                var responseCieloRepository = await _cieloRepository.CancelByPaymentId(paymentId);

                if (responseCieloRepository == null) 
                {
                    return null;
                }

                return _mapper.Map<CieloTransactionResponseDto>(responseCieloRepository);
            }
            catch (HttpRequestException ex)
            {
                throw new HttpRequestException("There was a problem communicating with the Cielo service. Please try again later.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("An unexpected error occurred. Please try again later.", ex);
            }
        }

        public async Task<CieloTransactionResponseDto> CaptureTransaction(string paymentId, int? amount, int? serviceTaxAmount)
        {
            try
            {
                var responseCieloRepository = await _cieloRepository.CaptureTransaction(paymentId, amount, serviceTaxAmount);

                if (responseCieloRepository == null)
                {
                    return null;
                }

                return _mapper.Map<CieloTransactionResponseDto>(responseCieloRepository);
            }
            catch (HttpRequestException ex)
            {
                throw new HttpRequestException("There was a problem communicating with the Cielo service. Please try again later.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("An unexpected error occurred. Please try again later.", ex);
            }
        }
    }
}
