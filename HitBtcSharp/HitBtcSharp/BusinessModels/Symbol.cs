using HitBtcSharp.BusinessModels.Enum;
using Newtonsoft.Json;

namespace HitBtcSharp.BusinessModels
{
    public class Symbol
    {
        [JsonProperty("id")]
        public ESymbol Id { get; set; }

        [JsonProperty("baseCurrency")]
        public ECurrency BaseCurrency { get; set; }

        [JsonProperty("quoteCurrency")]
        public ECurrency QuoteCurrency { get; set; }

        [JsonProperty("quantityIncrement")]
        public decimal QuantityIncrement { get; set; }

        [JsonProperty("tickSize")]
        public decimal TickSize { get; set; }

        [JsonProperty("takeLiquidityRate")]
        public decimal TakeLiquidityRate { get; set; }

        [JsonProperty("provideLiquidityRate")]
        public decimal ProvideLiquidityRate { get; set; }

        [JsonProperty("feeCurrency")]
        public ECurrency FeeCurrency { get; set; }
    }
}
