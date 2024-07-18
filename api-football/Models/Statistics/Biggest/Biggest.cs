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
        public required GameResult wins { get; set; }
        public required GameResult loses { get; set; }
    }
}
