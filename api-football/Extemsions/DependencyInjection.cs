using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using api_football.Extemsions.Http;
using Microsoft.Extensions.DependencyInjection;
namespace api_football.Extemsions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApiFootballServices(this IServiceCollection services, string apiKey)
        {
            return services;
        }

        public static IServiceCollection UseApiSportsClient(this IServiceCollection services, string apiKey)
        {
            services.AddSingleton<IHttpClientBuilder>(new ApiSportsClientBuilder(apiKey));
            return services;
        }

        public static IServiceCollection UseRapidApiClient(this IServiceCollection services, string apiKey)
        {
            services.AddSingleton<IHttpClientBuilder>(new RapidApiClientBuilder(apiKey));
            return services;
        }
        
    }
}
