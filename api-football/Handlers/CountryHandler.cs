using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using api_football.Models.Root;
using System.Text.Json;
using api_football.Models;
using api_football.Handlers.Interfaces;
namespace api_football.Handlers
{
    public class CountryHandler : GenericHandler, ICountryHandler
    {

        public CountryHandler(IHttpClientFactory clientFactory) : base(clientFactory)
        {
        }

        public async Task<RootCallResult<Country>> GetCountries(string? name, string? code, string? search)
        {
            var url = BuildUrl("countries", new string[] { "name", "code", "search" },
                            new Dictionary<string, string> { { "name", name }, { "code", code }, { "search", search } });

            var response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStreamAsync();
            if (response.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((await JsonSerializer.DeserializeAsync<ErrorMessage>(content)).message);

            return await JsonSerializer.DeserializeAsync<RootCallResult<Country>>(content);
        }


    }
}
