using Microsoft.AspNetCore.Mvc;
using Umbler.Application.Dtos.Requests;
using Umbler.Application.Dtos.Responses;
using Umbler.Application.Interfaces;
using Umbler.Domain.Entities.Request;
using Umbler.Domain.Entities.Response;

namespace Umbler.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ICieloTransactionService _cieloService;
        public TransactionController(ICieloTransactionService cieloService)
        {
            _cieloService = cieloService;
        }

        [HttpPost("CreateTransaction")]
        public async Task<ActionResult> CreateTransaction([FromBody] CreateTransactionDtoRequest request)
        {
            var response = await _cieloService.CreateCieloTransaction(request);

            if (response == null)
            {
                return BadRequest();
            }

            return Ok(response);
        }

        [HttpGet("GetByPaymentId/{paymentId}")]
        public async Task<ActionResult<GetByPaymentResponseDto>> GetByPaymentId([FromRoute] string paymentId)
        {
            var response = await _cieloService.GetByPaymentId(paymentId);

            if (response == null)
            {
                return BadRequest();
            }

            return Ok(response);
        }

        [HttpPut("CaptureTransaction/")]
        public async Task<ActionResult<CieloTransactionResponse>> CaptureTransaction([FromBody] CieloCaptureTransactionRequest captureTransaction) 
        {
            var response = await _cieloService.CaptureTransaction(captureTransaction.PaymentId, captureTransaction.Amount, captureTransaction.ServiceTaxAmount);

            if (response == null)
            {
                return BadRequest();
            }

            return Ok(response);
        }

        [HttpPut]
        [Route("CancelByPaymentId/{paymentId}")]
        public async Task<ActionResult<CieloTransactionResponse>> CancelByPaymentId([FromRoute] string paymentId) 
        {
            var response = await _cieloService.CancelByPaymentId(paymentId);

            if (response == null)
            {
                return BadRequest();
            }

            return Ok(response);
        }
    }
}
