using api_football.Handlers.Interfaces;
using api_football.Models.Common;
using api_football.Models.Root;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace api_football.Handlers
{
    public class SidelinesHandler : GenericHandler, ISidelinesHandler
    {
        public SidelinesHandler(IHttpClientFactory clientFactory)
            : base(clientFactory)
        {
        }

        public async Task<RootCallResult<TypeStartEnd[]>> GetSidelines(int? player, int? coach)
        {
            var url = BuildUrl("sidelined", new string[] {"player", "coach"},new Dictionary<string, string>
            {
                { "player", player?.ToString() },
                { "coach", coach?.ToString() }
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStreamAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((await JsonSerializer.DeserializeAsync<ErrorMessage>(content)).message);

            return await JsonSerializer.DeserializeAsync<RootCallResult<TypeStartEnd[]>>(content);
        }
    }
}
