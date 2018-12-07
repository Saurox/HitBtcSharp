using Newtonsoft.Json;
using System;

namespace HitBtcSharp.BusinessModels
{
    public class Trade
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("quantity")]
        public decimal Quantity { get; set; }

        [JsonProperty("side")]
        public ESide Side { get; set; }

        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; } 
    }
}
