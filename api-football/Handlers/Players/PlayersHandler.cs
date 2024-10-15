using api_football.Handlers.Interfaces;
using api_football.Models.Players;
using api_football.Models.Players.Squads;
using api_football.Models.Root;
using Newtonsoft.Json;

namespace api_football.Handlers.Players
{
    public class PlayersHandler : GenericHandler, IPlayersHandler
    {
        public PlayersHandler(IHttpClientFactory clientFactory) : base(clientFactory)
        {
        }

        public async Task<RootCallResult<int[]>> GetPlayersSeasons(int? id)
        {
            var url = BuildUrl("players/seasons", new string[] { "id" }, new Dictionary<string, object>
            {
                { "id", id.ToString() }
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<int[]>>(content);
        }

        public async Task<RootCallResult<Player[]>> GetPlayers(PlayerQueryParameters parameters)
        {
            var url = BuildUrl("players", new string[] { "id", "team", "league", "season", "search", "page" }, new Dictionary<string, object>
            {
                { "id", parameters.Id },
                { "team", parameters.Team },
                { "league", parameters.League },
                { "season", parameters.Season },
                { "search", parameters.Search },
                { "page", parameters.Page }
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<Player[]>>(content);
        }

        public async Task<RootCallResult<Squad[]>> GetSquads(SquadQueryParameters parameters)
        {
            var url = BuildUrl("players/squads", new string[] { "id", "team" }, new Dictionary<string, object>
            {
                { "id", parameters.Id },
                { "team", parameters.Team }
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<Squad[]>>(content);
        }

        public async Task<RootCallResult<TopStater[]>> GetTopScorers(TopStatQueryParameters parameters)
        {
            var url = BuildUrl("players/topscorers", new string[] { "league", "season" }, new Dictionary<string, object>
            {
                { "league", parameters.League },
                { "season", parameters.Season }
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<TopStater[]>>(content);
        }

        public async Task<RootCallResult<TopStater[]>> GetTopAssisters(TopStatQueryParameters parameters)
        {
            var url = BuildUrl("players/topassists", new string[] { "league", "season" }, new Dictionary<string, object>
            {
                { "league", parameters.League },
                { "season", parameters.Season }
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<TopStater[]>>(content);
        }

        public async Task<RootCallResult<TopStater[]>> GetTopYellowCardReceivers(TopStatQueryParameters parameters)
        {
            var url = BuildUrl("players/topyellowcards", new string[] { "league", "season" }, new Dictionary<string, object>
            {
                { "league", parameters.League },
                { "season", parameters.Season }
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<TopStater[]>>(content);
        }

        public async Task<RootCallResult<TopStater[]>> GetTopRedCardReceivers(TopStatQueryParameters parameters)
        {
            var url = BuildUrl("players/topredcards", new string[] { "league", "season" }, new Dictionary<string, object>
            {
                { "league", parameters.League },
                { "season", parameters.Season }
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<TopStater[]>>(content);
        }
    }
}