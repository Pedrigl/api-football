using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Fixtures.PlayersStatistics.Stats
{
    public class Penalties
    {
        public Penalties()
        {
        }
        public int? won { get; set; }
        public int? commited { get; set; }
        public int? scored { get; set; }
        public int? missed { get; set; }
        public int? saved { get; set; }
    }
}
