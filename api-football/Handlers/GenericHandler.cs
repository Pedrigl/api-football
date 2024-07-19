using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Handlers
{
    public class GenericHandler
    {
        protected HttpClient _client;

        public GenericHandler(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("api-football-client");
        }
    }
}
