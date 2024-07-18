using api_football.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Fixtures
{
    public class FixtureScore
    {
        public GenericHomeAway<int>? halftime { get; set; }
        public GenericHomeAway<int>? fulltime { get; set; }
        public GenericHomeAway<int>? extratime { get; set; }
        public GenericHomeAway<int>? penalty { get; set; }
    }
}
