using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Statistics.Biggest
{
    internal class Biggest
    {
        public required Streak streak { get; set; }
        public required HomeAwayStr wins { get; set; }
        public required HomeAwayStr loses { get; set; }
        public required ForAgainst goals { get; set; }
    }
}
