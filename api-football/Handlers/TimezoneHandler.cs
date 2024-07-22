using api_football.Handlers.Interfaces;
using api_football.Models.Root;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace api_football.Handlers
{
    public class TimezoneHandler : GenericHandler, ITimezoneHandler
    {
        public TimezoneHandler(IHttpClientFactory clientFactory) : base(clientFactory)
        {
        }

        public async Task<RootCallResult<string[]>> GetTimezones()
        {
            var response = await _client.GetAsync("timezone");
            var content = await response.Content.ReadAsStringAsync();
            if (response.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((JsonConvert.DeserializeObject<ErrorMessage>(content)).message);

            return JsonConvert.DeserializeObject<RootCallResult<string[]>>(content);
        }
    }
}
