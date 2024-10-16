﻿using System.Text;

namespace api_football.Handlers
{
    public class GenericHandler
    {
        protected HttpClient _client;

        public GenericHandler(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("api-football-client");
        }

        protected virtual string BuildUrl(string endpoint, string[] allowedParameters = null, Dictionary<string, object> parameters = null)
        {
            allowedParameters ??= Array.Empty<string>();
            parameters ??= new Dictionary<string, object>();
            parameters = parameters.Where(p => p.Value != null && p.Value != string.Empty && p.Value != "0").ToDictionary(p => p.Key, p => p.Value);
            string[] parametersNotAllowed = parameters.Keys.Where(p => !allowedParameters.Contains(p)).ToArray();

            if (parametersNotAllowed.Length > 0)
                throw new ArgumentException($"Invalid parameters: {parametersNotAllowed}");

            StringBuilder url = new StringBuilder(endpoint);

            if (parameters.Count > 0)
            {
                url.Append("?");
                foreach (var parameter in parameters)
                {
                    url.Append($"{parameter.Key}={parameter.Value}&");
                }

                url.Remove(url.Length - 1, 1);
            }

            return url.ToString();
        }
    }
}
