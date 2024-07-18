using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Fixtures.PlayersStatistics.Stats
{
    public class Goals
    {
        public int? total { get; set; }
        public int? conceded { get; set; }
        public int? assists { get; set; }
        public int? saves { get; set; }
    }
}
