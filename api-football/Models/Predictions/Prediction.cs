using api_football.Models.Fixtures;

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
