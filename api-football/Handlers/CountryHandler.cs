using api_football.Handlers.Interfaces;
using api_football.Models;
using api_football.Models.Root;
using Newtonsoft.Json;
namespace api_football.Handlers
{
    public class CountryHandler : GenericHandler, ICountryHandler
    {

        public CountryHandler(IHttpClientFactory clientFactory) : base(clientFactory)
        {
        }

        public async Task<RootCallResult<Country[]>> GetCountries(string? name, string? code, string? search)
        {
            var url = BuildUrl("countries", new string[] { "name", "code", "search" },
                            new Dictionary<string, string> { { "name", name }, { "code", code }, { "search", search } });

            var response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            if (response.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<Country[]>>(content);
        }


    }
}
