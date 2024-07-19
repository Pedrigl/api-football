using api_football.Handlers.Interfaces;
using api_football.Models.Root;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace api_football.Handlers
{
    public class TimezoneHandler : ITimezoneHandler
    {
        private readonly HttpClient _client;
        public TimezoneHandler(HttpClient client)
        {
            _client = client;
        }

        public async Task<RootCallResult<string[]>> GetTimezones()
        {
            var response = await _client.GetAsync("timezone");
            var content = await response.Content.ReadAsStreamAsync();
            if (response.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((await JsonSerializer.DeserializeAsync<ErrorMessage>(content)).message);

            return await JsonSerializer.DeserializeAsync<RootCallResult<string[]>>(content);
        }
    }
}
