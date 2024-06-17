using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Umbler.Domain.Entities.Request;
using Umbler.Domain.Entities.Response;
using Umbler.Domain.Interfaces;

namespace Umbler.Infrastructure.Repositories
{
    public class CieloTransactionRepository : ICieloTransactionRepository
    {
        private readonly HttpClient _httpClient;
        private readonly string _merchantId;
        private readonly string _merchantKey;
        private readonly string _createTransactionUrl;
        private readonly string _queryUrl;

        public CieloTransactionRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;

            _merchantId = "Insira seu merchantId";
            _merchantKey = "Insira seu merchantKey";

            _createTransactionUrl = "https://apisandbox.cieloecommerce.cielo.com.br/1/sales/";
            _queryUrl = "https://apiquerysandbox.cieloecommerce.cielo.com.br/1/sales";

            _httpClient.DefaultRequestHeaders.Add("MerchantId", _merchantId);
            _httpClient.DefaultRequestHeaders.Add("MerchantKey", _merchantKey);
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<CreateTransactionResponse> CreateCreditCardTransaction(CieloTransactionRequest request)
        {
            var response = await _httpClient.PostAsJsonAsync($"{_createTransactionUrl}", request);
            response.EnsureSuccessStatusCode();
            
            var responseContent = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<CreateTransactionResponse>(responseContent);
        }

        public async Task<GetByPaymentIdResponse> GetByPaymentId(string paymentId)
        {
            var response = await _httpClient.GetFromJsonAsync<GetByPaymentIdResponse>($"{_queryUrl}/{paymentId}");

            if (response == null)
            {
                return null;
            }

            return response;
        }

        public async Task<GetByMerchantOrderIdResponse> GetByMerchantOrderId(string merchantOrderId)
        {
            var response = await _httpClient.GetFromJsonAsync<GetByMerchantOrderIdResponse>($"{_queryUrl}?merchantOrderId={merchantOrderId}");

            if (response == null) 
            {
                return null;
            }

            return response;
        }

        public async Task<CieloTransactionResponse> CaptureTransaction(string paymentId, int? amount, int? serviceTaxAmount)
        {
            var requestUrl = $"{_createTransactionUrl}{paymentId}/capture";

            var response = await _httpClient.PutAsync(requestUrl, null);
            response.EnsureSuccessStatusCode();
            
            var responseContent = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<CieloTransactionResponse>(responseContent);
        }

        public async Task<CieloTransactionResponse> CancelByPaymentId(string paymentId)
        {
            var requestUrl = $"{_createTransactionUrl}{paymentId}/void";

            var response = await _httpClient.PutAsync(requestUrl, null);
            response.EnsureSuccessStatusCode();
            
            var responseContent = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<CieloTransactionResponse>(responseContent);
        }
    }
}
