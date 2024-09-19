using api_football.Models.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Fixtures.Lineups
{
    public class LineupTeam : Team
    {
        public LineupTeam() { }
        public LineupColors? colors { get; set; }
    }
}
