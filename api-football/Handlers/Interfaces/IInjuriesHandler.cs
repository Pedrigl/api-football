using api_football.Models.Injuries;
using api_football.Models.Root;

namespace api_football.Handlers.Interfaces
{
    public interface IInjuriesHandler
    {
        Task<RootCallResult<Injury[]>> GetInjuries(int? league, int? season, int? fixture, int? team, int? player, string? date, string? timezone);
    }
}
