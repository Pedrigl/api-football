using api_football.Models.Common;
using api_football.Models.Root;

namespace api_football.Handlers.Interfaces
{
    public interface ISidelinesHandler
    {
        Task<RootCallResult<TypeStartEnd[]>> GetSidelines(int? player, int? coach);
    }
}
