namespace api_football.Extensions.Http
{
    public class RapidApiClientBuilder : IClientBuilder
    {
        private readonly string _apiKey;
        private readonly HttpClient _client;

        public RapidApiClientBuilder(string apiKey)
        {
            _apiKey = apiKey;
            _client = new HttpClient();
        }

        public HttpClient Build()
        {
            _client.BaseAddress = new Uri("https://api-football-v1.p.rapidapi.com/v3/");
            _client.DefaultRequestHeaders.Clear();
            _client.DefaultRequestHeaders.Add("x-rapidapi-key", _apiKey);
            _client.DefaultRequestHeaders.Add("x-rapidapi-host", "api-football-v1.p.rapidapi.com");

            return _client;
        }

        public void Configure(HttpClient client)
        {
            client.BaseAddress = new Uri("https://api-football-v1.p.rapidapi.com/v3/");
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("x-rapidapi-key", _apiKey);
            client.DefaultRequestHeaders.Add("x-rapidapi-host", "api-football-v1.p.rapidapi.com");
        }
    }
}
