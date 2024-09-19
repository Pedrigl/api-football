using api_football.Models.Common;

namespace api_football.Models.Predictions
{
    public class PredictionFixtures
    {
        public PredictionFixtures()
        {
        }
        public required GenericHomeAwayTotal<int> played { get; set; }
        public required GenericHomeAwayTotal<int> wins { get; set; }
        public required GenericHomeAwayTotal<int> draws { get; set; }
        public required GenericHomeAwayTotal<int> loses { get; set; }
    }
}
