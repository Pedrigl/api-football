using api_football.Handlers.Injuries;
using api_football.Models;
using api_football.Models.Injuries;
using api_football.Models.Root;

namespace api_football.Handlers.Interfaces
{
    public interface IInjuriesHandler
    {
        Task<RootCallResult<Injury[]>> GetInjuries(InjuryQueryParameters parameters);
    }
}