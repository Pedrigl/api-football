using api_football.Models.Root;
using api_football.Models.Standings;

namespace api_football.Handlers.Interfaces
{
    public interface IStandingsHandler
    {
        Task<RootCallResult<Standing[]>> GetStandings(int? league, int season, int? team);
    }
}
