using Newtonsoft.Json;

namespace HitBtcSharp.BusinessModels
{
    public class DataOrderbook
    {
        [JsonProperty("price")]
        public decimal Price { get; set; }
        [JsonProperty("size")]
        public decimal Size { get; set; }
    }
}
