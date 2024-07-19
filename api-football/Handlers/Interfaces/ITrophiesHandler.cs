using api_football.Models.Root;
using api_football.Models.Trophies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Handlers.Interfaces
{
    public interface ITrophiesHandler
    {
        Task<RootCallResult<Trophy[]>> GetTrophies(int? player, int? coach);
    }
}
