using api_football.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Predictions
{
    public class PredictionFixtures
    {
        public required GenericHomeAwayTotal<int> played { get; set; }
        public required GenericHomeAwayTotal<int> wins { get; set; }
        public required GenericHomeAwayTotal<int> draws { get; set; }
        public required GenericHomeAwayTotal<int> loses { get; set; }
    }
}
