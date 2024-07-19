using api_football.Models.Injuries;
using api_football.Models.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Odds.PreGame
{
    public class PregameOdds
    {
        public required Statistics.League league { get; set; }
        public required Fixture fixture { get; set; }
        public DateTime update { get; set; }
        public required PregameBookmaker[] bookmakers { get; set; }
    }
}
