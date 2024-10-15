using api_football.Handlers.Interfaces;
using api_football.Models.Injuries;
using api_football.Models.Root;
using Newtonsoft.Json;

namespace api_football.Handlers.Injuries
{
    public class InjuriesHandler : GenericHandler, IInjuriesHandler
    {
        public InjuriesHandler(IHttpClientFactory clientFactory) : base(clientFactory)
        {
        }

        public async Task<RootCallResult<Injury[]>> GetInjuries(InjuryQueryParameters parameters)
        {
            var url = BuildUrl(
                "injuries",
                new string[] { "league", "season", "fixture", "team", "player", "date", "timezone" },
                new Dictionary<string, object>
                {
                    { "league", parameters.League },
                    { "season", parameters.Season },
                    { "fixture", parameters.Fixture },
                    { "team", parameters.Team },
                    { "player", parameters.Player },
                    { "date", parameters.Date },
                    { "timezone", parameters.Timezone }
                });

            var response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();

            if (response.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<Injury[]>>(content);
        }
    }
}