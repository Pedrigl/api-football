using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Extensions.Http
{
    public class ApiSportsClientBuilder : IClientBuilder
    {
        private readonly string _apiKey;
        private readonly IHttpClientFactory _clientFactory;
        public ApiSportsClientBuilder(string apiKey, IHttpClientFactory clientFactory)
        {
            _apiKey = apiKey;
            _clientFactory = clientFactory;
        }

        public HttpClient Build()
        {
            var client = _clientFactory.CreateClient();
            client.BaseAddress = new Uri("https://v3.football.api-sports.io/");
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("x-spisports-key", _apiKey);

            return client;
        }
    }
}
