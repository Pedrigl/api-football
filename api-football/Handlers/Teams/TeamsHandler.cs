using api_football.Handlers.Interfaces;
using api_football.Models;
using api_football.Models.Root;
using api_football.Models.Statistics;
using Newtonsoft.Json;
using Team = api_football.Models.Teams.Team;

namespace api_football.Handlers.Teams
{
    public class TeamsHandler : GenericHandler, ITeamsHandler
    {
        public TeamsHandler(IHttpClientFactory clientFactory) : base(clientFactory)
        {
        }

        public async Task<RootCallResult<Team[]>> GetTeamsInformations(TeamInfoQueryParameters parameters)
        {
            var url = BuildUrl("teams", new string[] 
            { 
                "id", "name", "league", "season", "country", "code", "venue", "search" 
            }, new Dictionary<string, object>
            {
                { "id", parameters.Id },
                { "name", parameters.Name },
                { "league", parameters.League },
                { "season", parameters.Season },
                { "country", parameters.Country },
                { "code", parameters.Code },
                { "venue", parameters.Venue },
                { "search", parameters.Search }
            });

            var response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();

            if (response.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<Team[]>>(content);
        }

        public async Task<RootCallResult<TeamStatistics>> GetTeamStatistics(TeamStatisticsQueryParameters parameters)
        {
            var url = BuildUrl("teams/statistics", new string[] 
            {
                "league", "season", "team", "date" 
            }, new Dictionary<string, object>
            {
                { "league", parameters.League },
                { "season", parameters.Season },
                { "team", parameters.Team },
                { "date", parameters.Date }
            });

            var response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();

            if (response.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<TeamStatistics>>(content);
        }

        public async Task<RootCallResult<int[]>> GetTeamSeasons(int team)
        {
            var url = BuildUrl("teams/seasons", new string[] { "team" }, new Dictionary<string, object>
            {
                { "team", team.ToString() }
            });

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