using api_football.Models.Common;
using api_football.Models.Root;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Handlers.Interfaces
{
    public interface ISidelinesHandler
    {
        Task<RootCallResult<TypeStartEnd[]>> GetSidelines(int? player, int? coach);
    }
}
