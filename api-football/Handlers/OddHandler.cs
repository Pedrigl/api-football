using api_football.Handlers.Interfaces;
using api_football.Models;
using api_football.Models.Odds.Live;
using api_football.Models.Odds.PreGame;
using api_football.Models.Odds.PreGame.Mapping;
using api_football.Models.Root;
using Newtonsoft.Json;

namespace api_football.Handlers
{
    public class OddHandler : GenericHandler, IOddHandler
    {
        public OddHandler(IHttpClientFactory clientFactory)
            : base(clientFactory)
        {
        }

        public async Task<RootCallResult<LiveOdd[]>> GetLiveOdds(int? fixture, int? league, int? bet)
        {
            var url = BuildUrl("odds/live", new string[] { "fixture", "league", "bet" }, new Dictionary<string, string>
            {
                {"fixture", fixture.ToString()},
                {"league", league.ToString()},
                {"bet", bet.ToString()}
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<LiveOdd[]>>(content);
        }

        public async Task<RootCallResult<IdNameTuple[]>> GetAvailableLiveBets(string? id, string? search)
        {
            var url = BuildUrl("odds/live/bets", new string[] { "id", "search" }, new Dictionary<string, string>
            {
                {"id", id},
                {"search", search}
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<IdNameTuple[]>>(content);
        }

        public async Task<RootCallResult<PregameOdds[]>> GetPreGameOdds(int? fixture, int? league, int? season, string? date, string? timezone, int? page, int? bookmaker, int? bet)
        {
            var url = BuildUrl("odds", new string[] { "fixture", "league", "season", "date", "timezone", "page", "bookmaker", "bet" }, new Dictionary<string, string>
            {
                {"fixture", fixture.ToString()},
                {"league", league.ToString()},
                {"season", season.ToString()},
                {"date", date},
                {"timezone", timezone},
                {"page", page.ToString()},
                {"bookmaker", bookmaker.ToString()},
                {"bet", bet.ToString()}
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<PregameOdds[]>>(content);
        }

        public async Task<RootCallResult<Mapping[]>> GetMappings(int? page)
        {
            var url = BuildUrl("odds/mappings", new string[] { "page" }, new Dictionary<string, string>
            {
                {"page", page.ToString()}
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<Mapping[]>>(content);
        }

        public async Task<RootCallResult<IdNameTuple[]>> GetAvailablePreGameBets(string? id, string? search)
        {
            var url = BuildUrl("odds/bets", new string[] { "id", "search" }, new Dictionary<string, string>
            {
                {"id", id},
                {"search", search}
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<IdNameTuple[]>>(content);
        }

        public async Task<RootCallResult<IdNameTuple[]>> GetAvailableBookMakers(string? id, string? search)
        {
            var url = BuildUrl("odds/bookmakers", new string[] { "id", "search" }, new Dictionary<string, string>
            {
                {"id", id},
                {"search", search}
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<IdNameTuple[]>>(content);
        }

    }
}
