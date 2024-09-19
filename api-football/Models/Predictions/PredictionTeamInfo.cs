using api_football.Models.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Predictions
{
    public class PredictionTeamInfo : Team
    {
        public PredictionTeamInfo()
        {
        }
        public Last5? last_5 { get; set; }
        public PredictionLeague? league { get; set; }
    }
}
