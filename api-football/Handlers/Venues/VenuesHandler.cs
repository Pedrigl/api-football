using api_football.Handlers.Interfaces;
using api_football.Models;
using api_football.Models.Root;
using Newtonsoft.Json;

namespace api_football.Handlers.Venues
{
    public class VenuesHandler : GenericHandler, IVenuesHandler
    {
        public VenuesHandler(IHttpClientFactory clientFactory) : base(clientFactory) { }

        public async Task<RootCallResult<Venue[]>> GetVenues(VenueSearchParameters parameters)
        {
            var url = BuildUrl("venues", new string[] { "id", "name", "city", "country", "search" },
                                new Dictionary<string, object> { { "id", parameters.Id }, {"name", parameters.Name }, { "city", parameters.City},
                                                                    {"country", parameters.Country }, {"search", parameters.Search} });

            var response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();

            if (response.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<Venue[]>>(content);
        }
    }
}
