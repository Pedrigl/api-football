using api_football.Models.Statistics.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Fixtures
{
    public class FixtureScore
    {
        public HomeAwayInt? halftime { get; set; }
        public HomeAwayInt? fulltime { get; set; }
        public HomeAwayInt? extratime { get; set; }
        public HomeAwayInt? penalty { get; set; }
    }
}
