using api_football.Models.Season;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.League
{
    public class League
    {
        public required LeagueInfo league { get; set; }
        public required Country country { get; set; }
        public required SeasonInfo[] seasons { get; set; }
    }
}
