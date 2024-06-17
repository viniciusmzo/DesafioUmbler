using Newtonsoft.Json;

namespace Umbler.Domain.Entities
{
    public class MerchantOrder
    {
        [JsonProperty("PaymentId")]
        public string PaymentId { get; set; }
        [JsonProperty("ReceveidDate")]
        public DateTime ReceveidDate { get; set; }
    }
}
