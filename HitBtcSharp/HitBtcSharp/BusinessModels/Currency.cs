using HitBtcSharp.BusinessModels.Enum;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitBtcSharp.BusinessModels
{
    public class Currency
    {
        [JsonProperty("id")]
        public ECurrency Id { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("crypto")]
        public bool Crypto { get; set; }

        [JsonProperty("payinEnabled")]
        public bool PayinEnabled { get; set; }

        [JsonProperty("payinPaymentId")]
        public bool PayinPaymentId { get; set; }

        [JsonProperty("payinConfirmations")]
        public int PayinConfirmations { get; set; }

        [JsonProperty("payoutEnabled")]
        public bool PayoutEnabled { get; set; }

        [JsonProperty("payoutIsPaymentId")]
        public bool PayoutIsPaymentId { get; set; }

        [JsonProperty("transferEnabled")]
        public bool TransferEnabled { get; set; }

        [JsonProperty("delisted")]
        public bool Delisted { get; set; }

        [JsonProperty("payoutFee")]
        public decimal PayoutFee { get; set; }
      
    }
}
