using api_football.Models.Coaches;
using api_football.Models.Root;

namespace api_football.Handlers.Interfaces
{
    public interface ICoachesHandler
    {
        Task<RootCallResult<Coach[]>> GetCoaches(int? id, int? team, string? search);
    }
}
