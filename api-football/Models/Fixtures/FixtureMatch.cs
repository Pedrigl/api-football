using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Fixtures
{
    public class FixtureMatch
    {
        internal FixtureMatch()
        {
        }
        public required FixtureTeam home { get; set; }
        public required FixtureTeam away { get; set; }
    }
}
