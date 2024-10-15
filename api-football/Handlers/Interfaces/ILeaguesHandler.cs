using api_football.Handlers.Leagues;
using api_football.Models;
using api_football.Models.League;
using api_football.Models.Root;

namespace api_football.Handlers.Interfaces
{
    public interface ILeaguesHandler
    {
        Task<RootCallResult<League[]>> GetLeagues(LeagueQueryParameters parameters);

        Task<RootCallResult<int[]>> GetSeasons();
    }
}