using api_football.Handlers.Teams;
using api_football.Models;
using api_football.Models.Root;
using api_football.Models.Statistics;
using api_football.Models.Teams;

namespace api_football.Handlers.Interfaces
{
    public interface ITeamsHandler
    {
        Task<RootCallResult<Models.Teams.Team[]>> GetTeamsInformations(TeamInfoQueryParameters parameters);
        Task<RootCallResult<TeamStatistics>> GetTeamStatistics(TeamStatisticsQueryParameters parameters);
        Task<RootCallResult<int[]>> GetTeamSeasons(int team);
        Task<RootCallResult<Country[]>> GetTeamsCountries();
    }
}