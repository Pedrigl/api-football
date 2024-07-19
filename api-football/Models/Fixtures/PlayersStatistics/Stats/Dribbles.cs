using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Fixtures.PlayersStatistics.Stats
{
    public class Dribbles
    {
        internal Dribbles()
        {
        }
        public int? attempts { get; set; }
        public int? success { get; set; }
        public int? past { get; set; }
    }
}
