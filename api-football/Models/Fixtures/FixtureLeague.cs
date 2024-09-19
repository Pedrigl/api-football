using api_football.Models.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Fixtures
{
    public class FixtureLeague : Statistics.League
    {
        public FixtureLeague()
        {
        }
        public required string round { get; set; }
    }
}
