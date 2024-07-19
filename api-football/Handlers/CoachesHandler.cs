using api_football.Handlers.Interfaces;
using api_football.Models.Coaches;
using api_football.Models.Root;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace api_football.Handlers
{
    public class CoachesHandler : GenericHandler, ICoachesHandler
    {
        public CoachesHandler(IHttpClientFactory clientFactory) : base(clientFactory)
        {
        }

        public async Task<RootCallResult<Coach[]>> GetCoaches(int? id, int? team, string? search)
        {
            var url = BuildUrl("coachs", new string[] {"id", "team", "search"}, new Dictionary<string, string>
            {
                {"id", id.ToString() },
                {"team", team.ToString() },
                {"search", search }
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStreamAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((await JsonSerializer.DeserializeAsync<ErrorMessage>(content)).message);

            return await JsonSerializer.DeserializeAsync < RootCallResult<Coach[]>>(content);
        }
    }
}
