using HitBtcSharp.BusinessModels;
using HitBtcSharp.BusinessModels.Enum;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System.Collections.Generic;

namespace HitBtcSharp.HBRestClient
{
    public class HBRestClient
    {
        private RestClient client = null;

        public HBRestClient(string endpoint, string key, string secret)
        {
            client = new RestClient(endpoint);
            client.Authenticator = new HttpBasicAuthenticator(key, secret);
        } 

        #region GetCurrencies
        public List<Currency> Currencies()
        {
            var request = new RestRequest("public/currency", Method.GET);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            return JsonConvert.DeserializeObject<List<Currency>>(content);
        }
        #endregion

        #region GetCurrency
        public Currency GetCurrency(ECurrency currency)
        {
            var request = new RestRequest($"public/currency/{currency.ToString()}", Method.GET);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            return JsonConvert.DeserializeObject<Currency>(content);
        }
        #endregion

        #region GetSymbols
        public List<Symbol> GetSymbols()
        {
            var request = new RestRequest("public/symbol", Method.GET);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            return JsonConvert.DeserializeObject<List<Symbol>>(content);
        }
        #endregion

        #region GetBalance
        public List<Balance> GetBalance()
        {
            var request = new RestRequest("trading/balance", Method.GET);
            IRestResponse response = client.Execute(request);
            var content = response.Content; 
            return JsonConvert.DeserializeObject<List<Balance>>(content);
        }
        #endregion

        #region GetOrders
        public List<Order> GetOrders()
        {
            var request = new RestRequest("order", Method.GET);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            return JsonConvert.DeserializeObject<List<Order>>(content);
        }
        #endregion

        #region CancelOrder
        public void CancelOrder()
        {
            var request = new RestRequest("order", Method.DELETE);
            IRestResponse response = client.Execute(request);
        }
        #endregion
    }
}
