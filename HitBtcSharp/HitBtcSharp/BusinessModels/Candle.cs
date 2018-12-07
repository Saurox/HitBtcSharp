using Newtonsoft.Json;
using System;

namespace HitBtcSharp.BusinessModels
{
    public class Candle
    {
        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("open")]
        public decimal Open { get; set; }

        [JsonProperty("close")]
        public decimal Close { get; set; }

        [JsonProperty("min")]
        public decimal Min { get; set; }

        [JsonProperty("max")]
        public decimal Max { get; set; }

        [JsonProperty("volume")]
        public decimal Volume { get; set; }

        [JsonProperty("volumeQuote")]
        public decimal VolumeQuote { get; set; }
    }
}
