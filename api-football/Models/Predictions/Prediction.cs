using api_football.Models.Fixtures;
using api_football.Models.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Predictions
{
    public class Prediction
    {
        public required PredictionsInfo predictions { get; set; }
        public required Statistics.League league { get; set; }
        public required PredictionTeams teams { get; set; }
        public required PredictionComparison comparison { get; set; }
        public required Fixture[] h2h { get; set; }
    }
}
