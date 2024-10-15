using api_football.Handlers.Coaches;
using api_football.Models;
using api_football.Models.Coaches;
using api_football.Models.Root;

namespace api_football.Handlers.Interfaces
{
    public interface ICoachesHandler
    {
        Task<RootCallResult<Coach[]>> GetCoaches(CoachQueryParameters parameters);
    }
}