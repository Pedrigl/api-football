using api_football.Handlers.Interfaces;
using api_football.Models;
using api_football.Models.Root;
using api_football.Models.Statistics;
using api_football.Models.Teams;
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Team = api_football.Models.Teams.Team;

namespace api_football.Handlers
{
    public class TeamsHandler : GenericHandler, ITeamsHandler
    {
        public TeamsHandler(IHttpClientFactory clientFactory) : base(clientFactory)
        {
        }

        public async Task<RootCallResult<Team[]>> GetTeamsInformations(int? id, string? name, int? league,
                                                                        int? season, string? country, string? code,
                                                                        int? venue, string? search)
        {
            var url = BuildUrl("teams", new string[] { "id", "name", "league", "season", "country", "code", "venue", "search" },
                                           new Dictionary<string, string> { { "id", id.ToString() }, { "name", name }, { "league", league.ToString() },
                                                                                                      { "season", season.ToString() }, { "country", country }, { "code", code },
                                                                                                      { "venue", venue.ToString() }, { "search", search } });

            var response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();

            if (response.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<Team[]>>(content);
        }

        public async Task<RootCallResult<TeamStatistics>> GetTeamStatistics(int league, int season, int team, string date)
        {
            var url = BuildUrl("teams/statistics", new string[] { "league", "season", "team", "date" },
                                                          new Dictionary<string, string> { { "league", league.ToString() }, { "season", season.ToString() },
                                                                                                                                                               { "team", team.ToString() }, { "date", date } });

            var response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();

            if (response.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<TeamStatistics>>(content);
        }

        public async Task<RootCallResult<int[]>> GetTeamSeasons(int team)
        {
            var url = BuildUrl("teams/seasons", new string[] { "team" },
                                                              new Dictionary<string, string> { { "team", team.ToString() } });

            var response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();

            if (response.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<int[]>>(content);
        }

        public async Task<RootCallResult<Country[]>> GetTeamsCountries()
        {
            var url = BuildUrl("teams/countries");

            var response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();

            if (response.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<Country[]>>(content);
        }
    }
}
