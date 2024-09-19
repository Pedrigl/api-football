using api_football.Models.Root;

namespace api_football.Handlers.Interfaces
{
    public interface ITimezoneHandler
    {
        Task<RootCallResult<string[]>> GetTimezones();
    }
}
