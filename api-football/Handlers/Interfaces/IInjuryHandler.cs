using api_football.Models.Injuries;
using api_football.Models.Root;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Handlers.Interfaces
{
    public interface IInjuryHandler
    {
        Task<RootCallResult<Injury[]>> GetInjuries(int? league, int? season, int? fixture, int? team, int? player, string? date, string? timezone);
    }
}
