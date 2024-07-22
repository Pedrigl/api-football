using api_football.Handlers.Interfaces;
using api_football.Models.Fixtures;
using api_football.Models.Fixtures.Lineups;
using api_football.Models.Fixtures.PlayersStatistics;
using api_football.Models.Root;
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace api_football.Handlers
{
    public class FixturesHandler : GenericHandler, IFixturesHandler
    {
        public FixturesHandler(IHttpClientFactory clientFactory) : base(clientFactory) { }

        public async Task<RootCallResult<string[]>> GetRounds(int league, int season, bool? current)
        {
            var url = BuildUrl("fixtures/rounds", new string[] {"league", "season", "current"},new Dictionary<string, string>
            {
                { "league", league.ToString() },
                { "season", season.ToString() },
                { "current", current?.ToString() }
            });

            var response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();

            if (response.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<string[]>>(content);
        }

        public async Task<RootCallResult<Fixture[]>> GetFixtures(int? id, string? ids, string? live, string? date, int? league, int? season, int? team, int? last, int? next, string? from, string? to, string? round, string? status, int? venue, string? timezone)
        {
            var url = BuildUrl("fixtures", new string[] { "id", "ids", "live", "date", "league", "season", "team", "last", "next", "from", "to", "round", "status", "venue", "timezone" }, new Dictionary<string, string>
            {
                { "id", id?.ToString() },
                { "ids", ids },
                { "live", live },
                { "date", date },
                { "league", league?.ToString() },
                { "season", season?.ToString() },
                { "team", team?.ToString() },
                { "last", last?.ToString() },
                { "next", next?.ToString() },
                { "from", from },
                { "to", to },
                { "round", round },
                { "status", status },
                { "venue", venue?.ToString() },
                { "timezone", timezone }
            });

            var response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();

            if (response.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<Fixture[]>>(content);
        }

        public async Task<RootCallResult<Fixture[]>> GetH2HFixtures(string h2h, string? date, int? league, int? season, int? last, int? next, string? from, string? to, string? status, int? venue, string? timezone)
        {
            var url = BuildUrl("fixtures/headtohead", new string[] {"h2h", "date", "league", "season", "last", "next", "from", "to", "status", "venue", "timezone" }, new Dictionary<string, string>
            {
                {"h2h", h2h },
                {"date", date },
                {"league", league.ToString() },
                {"season", season.ToString() },
                {"last", last.ToString() },
                {"next", next.ToString() },
                {"from", from},
                {"to", to},
                {"status", status},
                {"venue", venue.ToString() },
                {"timezone", timezone}
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<Fixture[]>>(content);
        }

        public async Task<RootCallResult<FixtureStats[]>> GetFixtureStatistics(int fixture, int? team, string? type)
        {
            var url = BuildUrl("fixtures/statistics", new string[] { "fixture", "team", "type" }, new Dictionary<string, string>
            {
                {"fixture", fixture.ToString() },
                {"team", team.ToString() },
                {"type", type }
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<FixtureStats[]>>(content);
        }

        public async Task<RootCallResult<FixtureEvent[]>> GetFixtureEvents(int fixture, int? team, string? player, string? type)
        {
            var url = BuildUrl("fixtures/events", new string[] { "fixture", "team", "player", "type" }, new Dictionary<string, string>
            {
                {"fixture", fixture.ToString() },
                {"team", team.ToString() },
                {"player", player},
                {"type", type }
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<FixtureEvent[]>>(content);
        }

        public async Task<RootCallResult<Lineup[]>> GetFixtureLineups(int fixture, int? team, int? player, string? type)
        {
            var url = BuildUrl("fixtures/lineups", new string[] { "fixture", "team", "player", "type" }, new Dictionary<string, string>
            {
                {"fixture", fixture.ToString() },
                {"team", team.ToString() },
                {"player", player.ToString() },
                {"type", type }
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<Lineup[]>>(content);
        }

        public async Task<RootCallResult<PlayerStats[]>> GetFixturePlayersStats(int fixture, int? team)
        {
            var url = BuildUrl("fixtures/players", new string[] { "fixture", "team" }, new Dictionary<string, string>
            {
                {"fixture", fixture.ToString() },
                {"team", team.ToString() }
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<PlayerStats[]>>(content);
        }
    }
}
