using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Odds.Live
{
    public class OddValue
    {
        public required string value { get; set; }
        public required string odd { get; set; }
        public required string handicap { get; set; }
        public bool? main { get; set; }
        public bool? suspended { get; set; }
    }
}
