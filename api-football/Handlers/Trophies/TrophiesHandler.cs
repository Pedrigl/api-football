using api_football.Handlers.Interfaces;
using api_football.Models.Root;
using api_football.Models.Trophies;
using Newtonsoft.Json;

namespace api_football.Handlers.Trophies
{
    public class TrophiesHandler : GenericHandler, ITrophiesHandler
    {
        public TrophiesHandler(IHttpClientFactory clientFactory) : base(clientFactory)
        {
        }

        public async Task<RootCallResult<Trophy[]>> GetTrophies(int? player, int? coach)
        {
            var url = BuildUrl("trophies", new string[] { "player", "coach" }, new Dictionary<string, object>
            {
                { "player", player?.ToString() },
                { "coach", coach?.ToString() }
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<Trophy[]>>(content);
        }
    }
}
