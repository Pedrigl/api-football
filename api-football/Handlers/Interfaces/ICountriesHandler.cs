using api_football.Handlers.Countries;
using api_football.Models;
using api_football.Models.Root;

namespace api_football.Handlers.Interfaces
{
    public interface ICountriesHandler
    {
        Task<RootCallResult<Country[]>> GetCountries(CountryQueryParameters parameters);
    }
}