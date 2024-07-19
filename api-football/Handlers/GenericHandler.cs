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

        protected virtual string BuildUrl(string endpoint, string[] allowedParameters =null, Dictionary<string, string> parameters = null)
        {
            allowedParameters ??= Array.Empty<string>();
            parameters ??= new Dictionary<string, string>();

            string[] parametersNotAllowed = parameters.Keys.Where(p => !allowedParameters.Contains(p)).ToArray();

            if (parametersNotAllowed.Length > 0)
                throw new ArgumentException($"Invalid parameters: {parametersNotAllowed}");

            StringBuilder url = new StringBuilder(endpoint);

            if (parameters.Count > 0)
            {
                url.Append("?");

                foreach (var parameter in parameters)
                {
                    if(parameter.Value != null)
                        url.Append($"{parameter.Key}={parameter.Value}&");
                }

                url.Remove(url.Length - 1, 1);
            }

            return url.ToString();
        }
    }
}
