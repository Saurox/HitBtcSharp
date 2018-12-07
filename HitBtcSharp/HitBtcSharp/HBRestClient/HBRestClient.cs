using HitBtcSharp.BusinessModels;
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

        public List<Balance> GetBalance()
        {
            var request = new RestRequest("trading/balance", Method.GET);
            IRestResponse response = client.Execute(request);
            var content = response.Content; 
            return JsonConvert.DeserializeObject<List<Balance>>(content);
        }

        public List<Order> GetOrders()
        {
            var request = new RestRequest("order", Method.GET);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            return JsonConvert.DeserializeObject<List<Order>>(content);
        }

        public void CancelOrder()
        {
            var request = new RestRequest("order", Method.DELETE);
            IRestResponse response = client.Execute(request);
        }
    }
}
