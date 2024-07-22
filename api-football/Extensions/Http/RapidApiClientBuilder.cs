using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Extensions.Http
{
    public class RapidApiClientBuilder : IClientBuilder
    {
        private readonly string _apiKey;
        private readonly IHttpClientFactory _clientFactory;

        public RapidApiClientBuilder(string apiKey, IHttpClientFactory clientFactory)
        {
            _apiKey = apiKey;
            _clientFactory = clientFactory;
        }

        public HttpClient Build()
        {
            var client = _clientFactory.CreateClient("api-football-client");
            client.BaseAddress = new Uri("https://api-football-v1.p.rapidapi.com/v3/");
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("x-rapidapi-key", _apiKey);
            client.DefaultRequestHeaders.Add("x-rapidapi-host", "api-football-v1.p.rapidapi.com");

            return client;
        }
    }
}
