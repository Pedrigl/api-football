using api_football.Models.Statistics.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Standing
{
    public class StandingStats
    {
        public int played { get; set; }
        public int win { get; set; }
        public int draw { get; set; }
        public int lose { get; set; }
        public required ForAgainstInt goals { get; set; }
    }
}
