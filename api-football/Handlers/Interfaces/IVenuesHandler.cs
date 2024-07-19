using api_football.Models;
using api_football.Models.Root;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Handlers.Interfaces
{
    public interface IVenuesHandler
    {
        Task<RootCallResult<Venue[]>> GetVenues(int? id, string? name, string? city, string? country,string? search);
    }
}
