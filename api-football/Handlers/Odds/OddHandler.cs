using api_football.Handlers.Interfaces;
using api_football.Models.Common;
using api_football.Models.Odds.Live;
using api_football.Models.Odds.PreGame;
using api_football.Models.Odds.PreGame.Mapping;
using api_football.Models.Root;
using Newtonsoft.Json;

namespace api_football.Handlers.Odds
{
    public class OddHandler : GenericHandler, IOddHandler
    {
        public OddHandler(IHttpClientFactory clientFactory)
            : base(clientFactory)
        {
        }

        public async Task<RootCallResult<LiveOdd[]>> GetLiveOdds(LiveOddQueryParameters parameters)
        {
            var url = BuildUrl("odds/live", new string[] { "fixture", "league", "bet" }, new Dictionary<string, object>
            {
                {"fixture", parameters.Fixture },
                {"league", parameters.League },
                {"bet", parameters.Bet }
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<LiveOdd[]>>(content);
        }

        public async Task<RootCallResult<IdNameTuple[]>> GetAvailableLiveBets(AvailableBetQueryParameters parameters)
        {
            var url = BuildUrl("odds/live/bets", new string[] { "id", "search" }, new Dictionary<string, object>
            {
                {"id", parameters.Id},
                {"search", parameters.Search}
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<IdNameTuple[]>>(content);
        }

        public async Task<RootCallResult<PregameOdds[]>> GetPreGameOdds(PreGameOddQueryParameters parameters)
        {
            var url = BuildUrl("odds", new string[] { "fixture", "league", "season", "date", "timezone", "page", "bookmaker", "bet" }, new Dictionary<string, object>
            {
                {"fixture", parameters.Fixture },
                {"league", parameters.League },
                {"season", parameters.Season },
                {"date", parameters.Date },
                {"timezone", parameters.Timezone },
                {"page", parameters.Page },
                {"bookmaker", parameters.Bookmaker },
                {"bet", parameters.Bet }
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<PregameOdds[]>>(content);
        }

        public async Task<RootCallResult<Mapping[]>> GetMappings(MappingQueryParameters parameters)
        {
            var url = BuildUrl("odds/mappings", new string[] { "page" }, new Dictionary<string, object>
            {
                {"page", parameters.Page }
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<Mapping[]>>(content);
        }

        public async Task<RootCallResult<IdNameTuple[]>> GetAvailablePreGameBets(AvailableBetQueryParameters parameters)
        {
            var url = BuildUrl("odds/bets", new string[] { "id", "search" }, new Dictionary<string, object>
            {
                {"id", parameters.Id},
                {"search", parameters.Search}
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<IdNameTuple[]>>(content);
        }
    }
}