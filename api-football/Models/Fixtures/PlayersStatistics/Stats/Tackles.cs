using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Fixtures.PlayersStatistics.Stats
{
    public class Tackles
    {
        public Tackles()
        {
        }
        public int? total { get; set; }
        public int? blocks { get; set; }
        public int? interceptions { get; set; }
    }
}
