using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Predictions
{
    public class PredictionTeams
    {
        public required PredictionTeamInfo home { get; set; }
        public required PredictionTeamInfo away { get; set; }
    }
}
