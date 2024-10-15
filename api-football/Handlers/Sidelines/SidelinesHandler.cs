using api_football.Handlers.Interfaces;
using api_football.Models.Common;
using api_football.Models.Root;
using Newtonsoft.Json;

namespace api_football.Handlers.Sidelines
{
    public class SidelinesHandler : GenericHandler, ISidelinesHandler
    {
        public SidelinesHandler(IHttpClientFactory clientFactory)
            : base(clientFactory)
        {
        }

        public async Task<RootCallResult<TypeStartEnd[]>> GetSidelines(int? player, int? coach)
        {
            var url = BuildUrl("sidelined", new string[] { "player", "coach" }, new Dictionary<string, object>
            {
                { "player", player?.ToString() },
                { "coach", coach?.ToString() }
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<TypeStartEnd[]>>(content);
        }
    }
}
