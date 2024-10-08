﻿using api_football.Handlers.Interfaces;
using api_football.Models.Injuries;
using api_football.Models.Root;
using Newtonsoft.Json;

namespace api_football.Handlers
{
    public class InjuriesHandler : GenericHandler, IInjuriesHandler
    {
        public InjuriesHandler(IHttpClientFactory clientFactory) : base(clientFactory)
        {
        }

        public async Task<RootCallResult<Injury[]>> GetInjuries(int? league, int? season, int? fixture, int? team, int? player, string? date, string? timezone)
        {
            var url = BuildUrl("injuries", new string[] { "league", "season", "fixture", "team", "player", "date", "timezone" },
                                               new Dictionary<string, string> { { "league", league.ToString() }, { "season", season.ToString() }, { "fixture", fixture.ToString() },
                                                                                                                  { "team", team.ToString() }, { "player", player.ToString() }, { "date", date }, { "timezone", timezone } });

            var response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();

            if (response.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<Injury[]>>(content);
        }
    }
}
