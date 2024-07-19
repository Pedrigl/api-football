using api_football.Models.Coachs;
using api_football.Models.Root;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Handlers.Interfaces
{
    public interface ICoachesHandler
    {
        Task<RootCallResult<Coach[]>> GetCoaches(int? id, int? team, string? search);
    }
}
