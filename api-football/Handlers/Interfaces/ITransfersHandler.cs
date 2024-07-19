using api_football.Models.Root;
using api_football.Models.Transfers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Handlers.Interfaces
{
    public interface ITransfersHandler
    {
        Task<RootCallResult<Transfer[]>> GetTransfers(int? player, int? team);
    }
}
