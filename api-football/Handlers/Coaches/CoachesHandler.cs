﻿using api_football.Handlers.Interfaces;
using api_football.Models.Coaches;
using api_football.Models.Root;
using Newtonsoft.Json;

namespace api_football.Handlers.Coaches
{
    public class CoachesHandler : GenericHandler, ICoachesHandler
    {
        public CoachesHandler(IHttpClientFactory clientFactory) : base(clientFactory)
        {
        }

        public async Task<RootCallResult<Coach[]>> GetCoaches(CoachQueryParameters parameters)
        {
            var url = BuildUrl(
                "coachs",
                new string[] { "id", "team", "search" },
                new Dictionary<string, object>
                {
                    { "id", parameters.Id },
                    { "team", parameters.Team },
                    { "search", parameters.Search }
                });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<Coach[]>>(content);
        }
    }
}