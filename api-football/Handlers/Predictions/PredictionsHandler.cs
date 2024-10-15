using api_football.Handlers.Interfaces;
using api_football.Models.Predictions;
using api_football.Models.Root;
using Newtonsoft.Json;

namespace api_football.Handlers.Predictions
{
    public class PredictionsHandler : GenericHandler, IPredictionsHandler
    {
        public PredictionsHandler(IHttpClientFactory clientFactory) : base(clientFactory)
        {
        }

        public async Task<RootCallResult<Prediction[]>> GetPredictions(int fixture)
        {
            var url = BuildUrl("predictions", new string[] { "fixture" }, new Dictionary<string, object>
            {
                { "fixture", fixture.ToString() }
            });

            var result = await _client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();

            if (result.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<Prediction[]>>(content);
        }
    }
}
