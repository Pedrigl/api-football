using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Fixtures.PlayersStatistics.Stats
{
    public class Passes
    {
        public Passes()
        {
        }
        public int? total { get; set; }
        public int? key { get; set; }
        public string? accuracy { get; set; }
    }
}
