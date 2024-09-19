using api_football.Models.Root;
using api_football.Models.Transfers;

namespace api_football.Handlers.Interfaces
{
    public interface ITransfersHandler
    {
        Task<RootCallResult<Transfer[]>> GetTransfers(int? player, int? team);
    }
}
