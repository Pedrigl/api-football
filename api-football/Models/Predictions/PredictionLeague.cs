using api_football.Models.Common;
using api_football.Models.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Predictions
{
    public class PredictionLeague
    {
        internal PredictionLeague()
        {
        }
        public required string form { get; set; }
        public required PredictionFixtures fixtures { get; set; }
        public required GenericForAgainst<GenericTotalAverage<GenericHomeAwayTotal<int>,GenericHomeAwayTotal<string>>> goals { get; set; }
        public required Biggest biggest { get; set; }
        public required GenericHomeAwayTotal<int> clean_sheet { get; set; }
        public required GenericHomeAwayTotal<int> failed_to_score { get; set; }
    }
}
