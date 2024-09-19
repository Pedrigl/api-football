using api_football.Models.Common;
using api_football.Models.Statistics;

namespace api_football.Models.Predictions
{
    public class PredictionLeague
    {
        public PredictionLeague()
        {
        }
        public required string form { get; set; }
        public required PredictionFixtures fixtures { get; set; }
        public required GenericForAgainst<GenericTotalAverage<GenericHomeAwayTotal<int>, GenericHomeAwayTotal<string>>> goals { get; set; }
        public required Biggest biggest { get; set; }
        public required GenericHomeAwayTotal<int> clean_sheet { get; set; }
        public required GenericHomeAwayTotal<int> failed_to_score { get; set; }
    }
}
