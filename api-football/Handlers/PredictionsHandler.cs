using api_football.Handlers.Interfaces;
using api_football.Models.Predictions;
using api_football.Models.Root;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace api_football.Handlers
{
    public class PredictionsHandler : GenericHandler, IPredictionsHandler
    {
        public PredictionsHandler(IHttpClientFactory clientFactory) : base(clientFactory)
        {
        }

        public async Task<RootCallResult<Prediction[]>> GetPredictions(int fixture)
        {
            var url = BuildUrl("predictions", new string[] {"fixture"},new Dictionary<string, string>
            {
                { "fixture", fixture.ToString() }
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStreamAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((await JsonSerializer.DeserializeAsync<ErrorMessage>(content)).message);

            return await JsonSerializer.DeserializeAsync<RootCallResult<Prediction[]>>(content);
        }
    }
}
