using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using api_football.Models.Common;

namespace api_football.Models.Statistics
{
    public class Biggest
    {
        public required WinDrawLossInt streak { get; set; }
        public required HomeAwayStr wins { get; set; }
        public required HomeAwayStr loses { get; set; }
        public required ForAgainst goals { get; set; }
    }
}
