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
    public class CountryHandler : ICountryHandler
    {
        private readonly HttpClient _client;

        public CountryHandler(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("api-football-client");
        }

        public async Task<RootCallResult<Country[]>> GetCountries()
        {
            var response = await _client.GetAsync("countries");
            var content = await response.Content.ReadAsStreamAsync();
            if (response.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((await JsonSerializer.DeserializeAsync<ErrorMessage>(content)).message);

            return await JsonSerializer.DeserializeAsync<RootCallResult<Country[]>>(content);
        }
    }
}
