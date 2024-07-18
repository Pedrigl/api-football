using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Fixtures
{
    public class FixtureTeam : Statistics.Team
    {
        public bool winner { get; set; }
    }
}
