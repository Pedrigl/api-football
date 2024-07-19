using api_football.Models;
using api_football.Models.Root;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Handlers.Interfaces
{
    public interface ICountryHandler
    {
        Task<RootCallResult<Country>> GetCountries(string? name, string? code, string? search);
    }
}
