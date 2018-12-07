using HitBtcSharp.BusinessModels.Enum;
using Newtonsoft.Json;

namespace HitBtcSharp.BusinessModels
{
    public class NewOrder
    {
        [JsonProperty("symbol")]
        public ESymbol Symbol { get; set; }

        [JsonProperty("side")]
        public ESide Side { get; set; }

        [JsonProperty("quantity")]
        public decimal Quantity { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }
    }
}
