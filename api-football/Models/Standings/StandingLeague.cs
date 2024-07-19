using api_football.Models.Standing;
using api_football.Models.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Standings
{
    public class StandingLeague : Statistics.League
    {
        public required List<List<Position>> standings { get; set; }
    }
}
