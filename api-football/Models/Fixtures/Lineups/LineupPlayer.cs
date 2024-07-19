using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Fixtures.Lineups
{
    public class LineupPlayer : IdNameTuple
    {
        internal LineupPlayer() { }
        public int number { get; set; }
        public string? pos { get; set; }
        public string? grid { get; set; }
    }
}
