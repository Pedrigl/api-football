using api_football.Extensions.Http;
using api_football.Handlers;
using api_football.Handlers.Coaches;
using api_football.Handlers.Countries;
using api_football.Handlers.Fixtures;
using api_football.Handlers.Injuries;
using api_football.Handlers.Interfaces;
using api_football.Handlers.Leagues;
using api_football.Handlers.Odds;
using api_football.Handlers.Players;
using api_football.Handlers.Predictions;
using api_football.Handlers.Sidelines;
using api_football.Handlers.Standings;
using api_football.Handlers.Teams;
using api_football.Handlers.Timezones;
using api_football.Handlers.Transfers;
using api_football.Handlers.Trophies;
using api_football.Handlers.Venues;
using Microsoft.Extensions.DependencyInjection;
namespace api_football.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApiFootballServices(this IServiceCollection services, IClientBuilder clientBuilder)
        {
            services.AddHttpClient("api-football-client", client => clientBuilder.Configure(client));
            services.AddTransient<ITimezoneHandler, TimezoneHandler>();
            services.AddTransient<ICountriesHandler, CountriesHandler>();
            services.AddTransient<ILeaguesHandler, LeaguesHandler>();
            services.AddTransient<ITeamsHandler, TeamsHandler>();
            services.AddTransient<IVenuesHandler, VenuesHandler>();
            services.AddTransient<IStandingsHandler, StandingHandler>();
            services.AddTransient<IFixturesHandler, FixturesHandler>();
            services.AddTransient<IInjuriesHandler, InjuriesHandler>();
            services.AddTransient<IPredictionsHandler, PredictionsHandler>();
            services.AddTransient<ICoachesHandler, CoachesHandler>();
            services.AddTransient<IPlayersHandler, PlayersHandler>();
            services.AddTransient<ITransfersHandler, TransfersHandler>();
            services.AddTransient<ITrophiesHandler, TrophiesHandler>();
            services.AddTransient<ISidelinesHandler, SidelinesHandler>();
            services.AddTransient<IOddHandler, OddHandler>();

            return services;
        }

    }
}
