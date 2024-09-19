using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Fixtures
{
    public class FixtureMatch
    {
        public FixtureMatch()
        {
        }
        public required FixtureTeam home { get; set; }
        public required FixtureTeam away { get; set; }
    }
}
