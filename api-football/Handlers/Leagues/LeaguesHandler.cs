using api_football.Handlers.Interfaces;
using api_football.Models.League;
using api_football.Models.Root;
using Newtonsoft.Json;

namespace api_football.Handlers.Leagues
{
    public class LeaguesHandler : GenericHandler, ILeaguesHandler
    {
        public LeaguesHandler(IHttpClientFactory clientFactory) : base(clientFactory)
        {
        }

        public async Task<RootCallResult<League[]>> GetLeagues(LeagueQueryParameters parameters)
        {
            var url = BuildUrl("leagues", new string[] {"id", "name", "country",
                                                        "code", "season", "team",
                                                        "type", "current", "search", "last"},
                                new Dictionary<string, object> {
                                    { "id", parameters.Id },
                                    { "name", parameters.Name },
                                    { "country", parameters.Country },
                                    { "code", parameters.Code },
                                    { "season", parameters.Season },
                                    { "team", parameters.Team },
                                    { "type", parameters.Type },
                                    { "current", parameters.Current },
                                    { "search", parameters.Search },
                                    { "last", parameters.Last }
                                });

            var response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();

            if (response.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<League[]>>(content);
        }

        public async Task<RootCallResult<int[]>> GetSeasons()
        {
            var url = BuildUrl("leagues");

            var response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();

            if (response.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<int[]>>(content);
        }
    }
}