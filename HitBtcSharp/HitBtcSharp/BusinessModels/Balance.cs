using HitBtcSharp.BusinessModels.Enum;
using Newtonsoft.Json;

namespace HitBtcSharp.BusinessModels
{
    public class Balance
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [JsonProperty("available")]
        public decimal Available { get; set; }
        [JsonProperty("reserved")]
        public decimal Reserved { get; set; }
    }
}
