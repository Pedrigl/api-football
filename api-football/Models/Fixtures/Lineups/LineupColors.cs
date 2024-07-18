using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Fixtures.Lineups
{
    public class LineupColors
    {
        public ShirtColors? player { get; set; }
        public ShirtColors? goalkeeper { get; set; }
    }
}
