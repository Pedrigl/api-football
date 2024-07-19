using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Fixtures.Lineups
{
    public class LineupPlayerInfo
    {
        internal LineupPlayerInfo() { }
        public required LineupPlayer player { get; set; }
    }
}
