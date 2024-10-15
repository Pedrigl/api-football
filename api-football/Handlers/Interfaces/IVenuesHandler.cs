using api_football.Models;
using api_football.Models.Root;

namespace api_football.Handlers.Interfaces
{
    public interface IVenuesHandler
    {
        Task<RootCallResult<Venue[]>> GetVenues(VenueSearchParameters parameters);
    }
}