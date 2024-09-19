using api_football.Models.League;
using api_football.Models.Root;

namespace api_football.Handlers.Interfaces
{
    public interface ILeaguesHandler
    {
        Task<RootCallResult<League[]>> GetLeagues(int? id, string? name, string? country,
                                                    string? code, int? season, int? team,
                                                    string? type, string? current, string? search, int? last);
        Task<RootCallResult<int[]>> GetSeasons();
    }
}
