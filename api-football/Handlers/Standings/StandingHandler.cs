﻿using api_football.Handlers.Interfaces;
using api_football.Models.Root;
using api_football.Models.Standings;
using Newtonsoft.Json;

namespace api_football.Handlers.Standings
{
    public class StandingHandler : GenericHandler, IStandingsHandler
    {
        public StandingHandler(IHttpClientFactory clientFactory) : base(clientFactory)
        {
        }

        public async Task<RootCallResult<Standing[]>> GetStandings(int? league, int season, int? team)
        {
            var url = BuildUrl("standings", new string[] { "league", "season", "team" }, new Dictionary<string, object>
            {
                { "league", league.ToString() },
                { "season", season.ToString() },
                { "team", team.ToString() }
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<Standing[]>>(content);
        }
    }
}
