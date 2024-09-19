using api_football.Models.Root;
using api_football.Models.Trophies;

namespace api_football.Handlers.Interfaces
{
    public interface ITrophiesHandler
    {
        Task<RootCallResult<Trophy[]>> GetTrophies(int? player, int? coach);
    }
}
