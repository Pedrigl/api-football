using api_football.Handlers.Interfaces;
using api_football.Models;
using api_football.Models.Root;
using Newtonsoft.Json;

namespace api_football.Handlers.Countries
{
    public class CountriesHandler : GenericHandler, ICountriesHandler
    {
        public CountriesHandler(IHttpClientFactory clientFactory) : base(clientFactory)
        {
        }

        public async Task<RootCallResult<Country[]>> GetCountries(CountryQueryParameters parameters)
        {
            var url = BuildUrl(
                "countries",
                new string[] { "name", "code", "search" },
                new Dictionary<string, object>
                {
                    { "name", parameters.Name },
                    { "code", parameters.Code },
                    { "search", parameters.Search }
                });

            var response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();

            if (response.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<Country[]>>(content);
        }
    }
}