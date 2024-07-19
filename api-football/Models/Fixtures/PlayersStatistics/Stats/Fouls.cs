using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Fixtures.PlayersStatistics.Stats
{
    public class Fouls
    {
        internal Fouls()
        {
        }
        public int? drawn { get; set; }
        public int? committed { get; set; }
    }
}
