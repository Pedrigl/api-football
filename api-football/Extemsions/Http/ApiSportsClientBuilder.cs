using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Extemsions.Http
{
    internal class ApiSportsClientBuilder : IHttpClientBuilder
    {
        private readonly string _apiKey;

        public ApiSportsClientBuilder(string apiKey)
        {
            _apiKey = apiKey;
        }

        public HttpClient Build()
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(" https://v3.football.api-sports.io/"),
                DefaultRequestHeaders =
                {
                    { "x-spisports-key", _apiKey }
                },
            };
            return client;
        }
    }
}
