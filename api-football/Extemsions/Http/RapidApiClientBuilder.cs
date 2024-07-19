using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Extemsions.Http
{
    internal class RapidApiClientBuilder : IHttpClientBuilder
    {
        private readonly string _apiKey;

        public RapidApiClientBuilder(string apiKey)
        {
            _apiKey = apiKey;
        }

        public HttpClient Build()
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri("https://api-football-v1.p.rapidapi.com/v3/"),
                DefaultRequestHeaders =
                {
                    { "x-rapidapi-key", _apiKey },
                    { "x-rapidapi-host", "api-football-v1.p.rapidapi.com" },
                },
            };
            return client;
        }
    }
}
