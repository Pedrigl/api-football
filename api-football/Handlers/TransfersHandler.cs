using api_football.Handlers.Interfaces;
using api_football.Models.Root;
using api_football.Models.Transfers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace api_football.Handlers
{
    public class TransfersHandler : GenericHandler, ITransfersHandler
    {
        public TransfersHandler(IHttpClientFactory clientFactory) : base(clientFactory)
        {
        }

        public async Task<RootCallResult<Transfer[]>> GetTransfers(int? player, int? team)
        {
            var url = BuildUrl("transfers", new string[] {"player", "team"},new Dictionary<string, string>
            {
                { "player", player?.ToString() },
                { "team", team?.ToString() }
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStreamAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((await JsonSerializer.DeserializeAsync<ErrorMessage>(content)).message);

            return await JsonSerializer.DeserializeAsync<RootCallResult<Transfer[]>>(content);
        }
    }
}
