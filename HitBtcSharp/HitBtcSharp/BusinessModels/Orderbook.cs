using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace HitBtcSharp.BusinessModels
{
    public class Orderbook
    {
        [JsonProperty("ask")]
        public List<DataOrderbook> Ask { get; set; }

        [JsonProperty("bid")]
        public List<DataOrderbook> Bid { get; set; }

        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        public Orderbook()
        {
            Ask = new List<DataOrderbook>();
            Bid = new List<DataOrderbook>();
        }
    }
}
