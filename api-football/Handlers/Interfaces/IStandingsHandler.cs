using api_football.Models.Root;
using api_football.Models.Standings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Handlers.Interfaces
{
    public interface IStandingsHandler
    {
        Task<RootCallResult<Standing[]>> GetStandings(int? league, int season, int? team);
    }
}
