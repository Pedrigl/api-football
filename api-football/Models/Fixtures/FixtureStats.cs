using api_football.Models.Common;
using api_football.Models.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Fixtures
{
    public class FixtureStats
    {
        public required Team team { get; set; }
        public TypeValuePair<int>[]? statistics { get; set; }
    }
}
