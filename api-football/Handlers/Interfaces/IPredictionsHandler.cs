using api_football.Models.Predictions;
using api_football.Models.Root;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Handlers.Interfaces
{
    public interface IPredictionsHandler
    {
        Task<RootCallResult<Prediction[]>> GetPredictions(int fixture);
    }
}
