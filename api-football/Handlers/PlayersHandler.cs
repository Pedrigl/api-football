using api_football.Handlers.Interfaces;
using api_football.Models.Players;
using api_football.Models.Players.Squads;
using api_football.Models.Root;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace api_football.Handlers
{
    public class PlayersHandler : GenericHandler, IPlayersHandler
    {
        public PlayersHandler(IHttpClientFactory clientFactory) : base(clientFactory)
        {
        }

        public async Task<RootCallResult<int[]>> GetPlayersSeasons(int? id)
        {
            var url = BuildUrl("players/seasons", new string[] {"id"}, new Dictionary<string, string>
            {
                {"id", id.ToString() } }
            );

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStreamAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((await JsonSerializer.DeserializeAsync<ErrorMessage>(content)).message);

            return await JsonSerializer.DeserializeAsync<RootCallResult<int[]>>(content);
        }

        public async Task<RootCallResult<Player[]>> GetPlayers(int? id, int? team, int? league, int? season, string? search, int? page)
        {
            var url = BuildUrl("players", new string[] { "id", "team", "league", "season", "search", "page" }, new Dictionary<string, string>
            {
                {"id", id.ToString() },
                {"team", team.ToString() },
                {"league", league.ToString() },
                {"season", season.ToString() },
                {"search", search },
                {"page", page.ToString() }
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStreamAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((await JsonSerializer.DeserializeAsync<ErrorMessage>(content)).message);

            return await JsonSerializer.DeserializeAsync<RootCallResult<Player[]>>(content);
        }

        public async Task<RootCallResult<Squad[]>> GetSquads(int? id, int? team)
        {
            var url = BuildUrl("players/squads", new string[] { "id", "team" }, new Dictionary<string, string>
            {
                {"id", id.ToString() },
                {"team", team.ToString() }
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStreamAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((await JsonSerializer.DeserializeAsync<ErrorMessage>(content)).message);

            return await JsonSerializer.DeserializeAsync<RootCallResult<Squad[]>>(content);
        }

        public async Task<RootCallResult<TopStater[]>> GetTopScorers(int league, int season)
        {
            var url = BuildUrl("players/topscorers", new string[] { "league", "season" }, new Dictionary<string, string>
            {
                {"league", league.ToString() },
                {"season", season.ToString() }
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStreamAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((await JsonSerializer.DeserializeAsync<ErrorMessage>(content)).message);

            return await JsonSerializer.DeserializeAsync<RootCallResult<TopStater[]>>(content);
        }

        public async Task<RootCallResult<TopStater[]>> GetTopAssisters(int league, int season)
        {
            var url = BuildUrl("players/topassists", new string[] { "league", "season" }, new Dictionary<string, string>
            {
                {"league", league.ToString() },
                {"season", season.ToString() }
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStreamAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((await JsonSerializer.DeserializeAsync<ErrorMessage>(content)).message);

            return await JsonSerializer.DeserializeAsync<RootCallResult<TopStater[]>>(content);
        }

        public async Task<RootCallResult<TopStater[]>> GetTopYellowCardReceivers(int league, int season)
        {
            var url = BuildUrl("players/topyellowcards", new string[] { "league", "season" }, new Dictionary<string, string>
            {
                {"league", league.ToString() },
                {"season", season.ToString() }
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStreamAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((await JsonSerializer.DeserializeAsync<ErrorMessage>(content)).message);

            return await JsonSerializer.DeserializeAsync<RootCallResult<TopStater[]>>(content);
        }

        public async Task<RootCallResult<TopStater[]>> GetTopRedCardReceivers(int league, int season)
        {
            var url = BuildUrl("players/topredcards", new string[] { "league", "season" }, new Dictionary<string, string>
            {
                {"league", league.ToString() },
                {"season", season.ToString() }
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStreamAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((await JsonSerializer.DeserializeAsync<ErrorMessage>(content)).message);

            return await JsonSerializer.DeserializeAsync<RootCallResult<TopStater[]>>(content);
        }
    }
}
