using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Fixtures.PlayersStatistics.Stats
{
    public class Statistics
    {
        internal Statistics()
        {
        }
        public required GamesPlayed games { get; set; }
        public int? offsides { get; set; }
        public required Shots shots { get; set; }
        public required Goals goals { get; set; }
        public required Passes passes { get; set; }
        public required Tackles tackles { get; set; }
        public required Duels duels { get; set; }
        public required Dribbles dribbles { get; set; }
        public required Fouls fouls { get; set; }
        public required Cards cards { get; set; }
        public required Penalties penalty { get; set; }
    }
}
