using HitBtcSharp.BusinessModels.Enum;
using Newtonsoft.Json;
using System;

namespace HitBtcSharp.BusinessModels
{
    public class Ticker
    {
        [JsonProperty("ask")]
        public decimal Ask { get; set; }
        [JsonProperty("bid")]
        public decimal Bid { get; set; }
        [JsonProperty("last")]
        public decimal Last { get; set; }
        [JsonProperty("open")]
        public decimal Open { get; set; }
        [JsonProperty("low")]
        public decimal Low { get; set; }
        [JsonProperty("high")]
        public decimal High { get; set; }
        [JsonProperty("volume")]
        public decimal Volume { get; set; }
        [JsonProperty("volumeQuote")]
        public decimal VolumeQuote { get; set; }
        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }
        [JsonProperty("symbol")]
        public ESymbol Symbol { get; set; }
    }
}
