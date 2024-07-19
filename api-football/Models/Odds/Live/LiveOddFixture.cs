using api_football.Models.Fixtures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Odds.Live
{
    public class LiveOddFixture
    {
        public int id { get; set; }
        public required FixtureStatus status { get; set; }
    }
}
