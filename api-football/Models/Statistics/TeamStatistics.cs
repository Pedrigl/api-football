using api_football.Models.Statistics.Common;
using api_football.Models.Statistics.Goals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace api_football.Models.Statistics
{
    public class TeamStatistics
    {
        public required League league { get; set; }
        public required Team team { get; set; }
        public required string form { get; set; }
        public required Fixtures fixtures { get; set; } 
        public required GoalsScored goals { get; set; }
        public required Biggest biggest { get; set; }
        public required HomeAwayTotalInt clean_sheet { get; set; }
        public required HomeAwayTotalInt failed_to_score { get; set; }
        public required Penalties penalty { get; set; }
        public FormationPlayed[]? lineups { get; set; }
        public required Cards cards { get; set; }
    }
}
