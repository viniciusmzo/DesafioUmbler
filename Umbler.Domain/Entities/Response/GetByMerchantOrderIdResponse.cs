using Newtonsoft.Json;

namespace Umbler.Domain.Entities.Response
{
    public class GetByMerchantOrderIdResponse
    {
        [JsonProperty("ReasonCode")]
        public int ReasonCode { get; set; }

        [JsonProperty("ReasonMessage")]
        public string ReasonMessage { get; set; }

        [JsonProperty("Payments")]
        public List<MerchantOrder> Payments { get; set; }
    }
}
