using api_football.Models;
using api_football.Models.Root;

namespace api_football.Handlers.Interfaces
{
    public interface ICountryHandler
    {
        Task<RootCallResult<Country[]>> GetCountries(string? name, string? code, string? search);
    }
}
