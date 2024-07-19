using System;
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
            services.AddTransient<ILeaguesHandler,LeaguesHandler>();
            services.AddTransient<ITeamsHandler,TeamsHandler>();
            services.AddTransient<IVenuesHandler,VenuesHandler>();
            services.AddTransient<IStandingsHandler, StandingHandler>();
            services.AddTransient<IFixturesHandler, FixturesHandler>();
            services.AddTransient<IInjuriesHandler, InjuriesHandler>();
            services.AddTransient<IPredictionsHandler, PredictionsHandler>();
            services.AddTransient<ICoachesHandler, CoachesHandler>();

            return services;
        }
        
    }
}
