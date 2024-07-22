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
        private readonly HttpClient _client;
        public ApiSportsClientBuilder(string apiKey)
        {
            _apiKey = apiKey;
            _client = new HttpClient();
        }

        public HttpClient Build()
        {
            _client.BaseAddress = new Uri("https://v3.football.api-sports.io/");
            _client.DefaultRequestHeaders.Clear();
            _client.DefaultRequestHeaders.Add("x-spisports-key", _apiKey);

            return _client;
        }

        public void Configure(HttpClient client)
        {
            client.BaseAddress = new Uri("https://v3.football.api-sports.io/");
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("x-spisports-key", _apiKey);
        }
    }
}
