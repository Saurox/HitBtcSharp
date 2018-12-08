using HitBtcSharp.BusinessModels;
using HitBtcSharp.BusinessModels.Enum;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;
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

        #region GetSymbol
        public Symbol GetSymbol(ESymbol symbol)
        {
            var request = new RestRequest($"public/symbol/{symbol.ToString()}", Method.GET);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            return JsonConvert.DeserializeObject<Symbol>(content);
        }
        #endregion

        #region GetTickers
        public List<Ticker> GetTickers()
        {
            var request = new RestRequest("public/ticker", Method.GET);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            return JsonConvert.DeserializeObject<List<Ticker>>(content);
        }
        #endregion

        #region GetTicker
        public Ticker GetTicker(ESymbol symbol)
        {
            var request = new RestRequest($"public/ticker/{symbol.ToString()}", Method.GET);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            return JsonConvert.DeserializeObject<Ticker>(content);
        }
        #endregion

        #region GetTrades
        public List<Trade> GetTrades(ESymbol symbol)
        {
            var request = new RestRequest($"public/trades/{symbol.ToString()}", Method.GET);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            return JsonConvert.DeserializeObject<List<Trade>>(content);
        }
        #endregion

        #region GetOrderbook
        public Orderbook GetOrderbook(ESymbol symbol)
        {
            var request = new RestRequest($"public/orderbook/{symbol.ToString()}", Method.GET);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            return JsonConvert.DeserializeObject<Orderbook>(content);
        }
        #endregion

        #region GetCandles
        public List<Candle> GetCandles(ESymbol symbol)
        {
            var request = new RestRequest($"public/candles/{symbol.ToString()}", Method.GET);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            return JsonConvert.DeserializeObject<List<Candle>>(content);
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

        #region GetOrder
        public Order GetOrder(Guid clientOrderId)
        {
            var request = new RestRequest($"order/{clientOrderId.ToString()}", Method.GET);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            return JsonConvert.DeserializeObject<Order>(content);
        }
        #endregion

        #region SendOrder
        public Order SendOrder()
        {
            var request = new RestRequest($"order", Method.POST);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            return JsonConvert.DeserializeObject<Order>(content);
        }
        #endregion

        #region ModifyOrder
        public Order ModifyOrder(Guid clientOrderId)
        {
            var request = new RestRequest($"order/{clientOrderId}", Method.PUT);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            return JsonConvert.DeserializeObject<Order>(content);
        }
        #endregion

        #region CancelAllOrder
        public void CancelAllOrder()
        {
            var request = new RestRequest("order", Method.DELETE);
            IRestResponse response = client.Execute(request);
        }
        #endregion

        #region CancelOrder
        public void CancelOrder(Guid clientOrderId)
        {
            var request = new RestRequest($"order/{clientOrderId}", Method.DELETE);
            IRestResponse response = client.Execute(request);
        }
        #endregion
    }
}
