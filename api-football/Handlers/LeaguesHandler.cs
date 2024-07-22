using api_football.Handlers.Interfaces;
using api_football.Models.League;
using api_football.Models.Root;
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace api_football.Handlers
{
    public class LeaguesHandler : GenericHandler, ILeaguesHandler
    {
        public LeaguesHandler(IHttpClientFactory clientFactory) : base(clientFactory)
        {
        }

        public async Task<RootCallResult<League[]>> GetLeagues(int? id, string? name, string? country,
                                                               string? code, int? season, int? team,
                                                               string? type, string? current, string? search, int? last)
        {
            var url = BuildUrl("leagues", new string[] {"id", "name", "country",
                                                        "code", "season", "team",
                                                        "type", "current", "search", "last"},
                                new Dictionary<string, string> { { "id", id.ToString()}, { "name", name}, {"country", country }
                                                                ,{"code", code}, {"season", season.ToString()}, {"team", team.ToString()}
                                                                ,{"type", type}, {"current", current}, {"search", search}, {"last", last.ToString()} });

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
