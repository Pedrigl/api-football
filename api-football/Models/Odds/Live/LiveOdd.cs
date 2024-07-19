using api_football.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Odds.Live
{
    public class LiveOdd
    {
        public required LiveOddFixture fixture { get; set; }
        public required OddLeague league { get; set; }
        public required GenericHomeAway<LiveOddTeams> teams { get; set; }
        public required LiveOddStatus status { get; set; }
        public DateTime update { get; set; }
        public required OddInfo[] odds { get; set; }
    }
}
