using api_football.Handlers.Interfaces;
using api_football.Models.Fixtures;
using api_football.Models.Fixtures.Lineups;
using api_football.Models.Fixtures.PlayersStatistics;
using api_football.Models.Root;
using Newtonsoft.Json;

namespace api_football.Handlers.Fixtures
{
    public class FixturesHandler : GenericHandler, IFixturesHandler
    {
        public FixturesHandler(IHttpClientFactory clientFactory) : base(clientFactory) { }

        public async Task<RootCallResult<string[]>> GetRounds(int league, int season, bool? current)
        {
            var url = BuildUrl("fixtures/rounds", new string[] { "league", "season", "current" }, new Dictionary<string, object>
            {
                { "league", league },
                { "season", season },
                { "current", current }
            });

            var response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();

            if (response.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<string[]>>(content);
        }

        public async Task<RootCallResult<Fixture[]>> GetFixtures(FixtureQueryParameters parameters)
        {
            var url = BuildUrl("fixtures", new string[]
            {
                "id", "ids", "live", "date", "league", "season", "team", "last", "next",
                "from", "to", "round", "status", "venue", "timezone"
            }, new Dictionary<string, object>
            {
                { "id", parameters.Id },
                { "ids", parameters.Ids },
                { "live", parameters.Live },
                { "date", parameters.Date },
                { "league", parameters.League },
                { "season", parameters.Season },
                { "team", parameters.Team },
                { "last", parameters.Last },
                { "next", parameters.Next },
                { "from", parameters.From },
                { "to", parameters.To },
                { "round", parameters.Round },
                { "status", parameters.Status },
                { "venue", parameters.Venue },
                { "timezone", parameters.Timezone }
            });

            var response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();

            if (response.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<Fixture[]>>(content);
        }

        public async Task<RootCallResult<Fixture[]>> GetH2HFixtures(H2HFixtureQueryParameters parameters)
        {
            var url = BuildUrl("fixtures/headtohead", new string[]
            {
                "h2h", "date", "league", "season", "last", "next", "from", "to", "status",
                "venue", "timezone"
            }, new Dictionary<string, object>
            {
                { "h2h", parameters.H2H },
                { "date", parameters.Date },
                { "league", parameters.League },
                { "season", parameters.Season },
                { "last", parameters.Last },
                { "next", parameters.Next },
                { "from", parameters.From },
                { "to", parameters.To },
                { "status", parameters.Status },
                { "venue", parameters.Venue },
                { "timezone", parameters.Timezone }
            });

            var response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();

            if (response.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<Fixture[]>>(content);
        }

        public async Task<RootCallResult<FixtureStats[]>> GetFixtureStatistics(FixtureQueryParams parameters)
        {
            var url = BuildUrl("fixtures/statistics", new string[] { "fixture", "team", "type" }, new Dictionary<string, object>
            {
                { "fixture", parameters.Fixture },
                { "team", parameters.Team },
                { "type", parameters.Type }
            });

            var response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();

            if (response.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<FixtureStats[]>>(content);
        }

        public async Task<RootCallResult<FixtureEvent[]>> GetFixtureEvents(FixtureEventQueryParams parameters)
        {
            var url = BuildUrl("fixtures/events", new string[] { "fixture", "team", "player", "type" }, new Dictionary<string, object>
            {
                { "fixture", parameters.Fixture },
                { "team", parameters.Team },
                { "player", parameters.Player },
                { "type", parameters.Type }
            });

            var response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();

            if (response.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<FixtureEvent[]>>(content);
        }

        public async Task<RootCallResult<Lineup[]>> GetFixtureLineups(FixtureLineupQueryParams parameters)
        {
            var url = BuildUrl("fixtures/lineups", new string[] { "fixture", "team", "player", "type" }, new Dictionary<string, object>
            {
                { "fixture", parameters.Fixture },
                { "team", parameters.Team },
                { "player", parameters.Player },
                { "type", parameters.Type }
            });

            var response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();

            if (response.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<Lineup[]>>(content);
        }

        public async Task<RootCallResult<PlayerStats[]>> GetFixturePlayersStats(FixturePlayerStatsQueryParams parameters)
        {
            var url = BuildUrl("fixtures/players", new string[] { "fixture", "team" }, new Dictionary<string, object>
            {
                { "fixture", parameters.Fixture },
                { "team", parameters.Team }
            });

            var response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();

            if (response.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<PlayerStats[]>>(content);
        }
    }
}