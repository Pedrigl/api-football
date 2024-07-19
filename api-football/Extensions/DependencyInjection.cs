﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using api_football.Extensions.Http;
using api_football.Handlers.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using api_football.Handlers;
namespace api_football.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApiFootballServices(this IServiceCollection services, IClientBuilder clientBuilder, string apiKey)
        {
            services.AddHttpClient("api-football-client", client => clientBuilder.Build());
            services.AddTransient<ITimezoneHandler,TimezoneHandler>();
            services.AddTransient<ICountryHandler,CountryHandler>();
            return services;
        }
        
    }
}