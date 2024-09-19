using api_football.Handlers.Interfaces;
using api_football.Models.Root;
using api_football.Models.Transfers;
using Newtonsoft.Json;

namespace api_football.Handlers
{
    public class TransfersHandler : GenericHandler, ITransfersHandler
    {
        public TransfersHandler(IHttpClientFactory clientFactory) : base(clientFactory)
        {
        }

        public async Task<RootCallResult<Transfer[]>> GetTransfers(int? player, int? team)
        {
            var url = BuildUrl("transfers", new string[] { "player", "team" }, new Dictionary<string, string>
            {
                { "player", player?.ToString() },
                { "team", team?.ToString() }
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<Transfer[]>>(content);
        }
    }
}
