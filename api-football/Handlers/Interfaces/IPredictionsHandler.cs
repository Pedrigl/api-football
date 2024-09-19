using api_football.Models.Predictions;
using api_football.Models.Root;

namespace api_football.Handlers.Interfaces
{
    public interface IPredictionsHandler
    {
        Task<RootCallResult<Prediction[]>> GetPredictions(int fixture);
    }
}
