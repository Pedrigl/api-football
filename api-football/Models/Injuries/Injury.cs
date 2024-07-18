using api_football.Models.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Injuries
{
    public class Injury
    {
        public required PlayerInjured player { get; set; }
        public required Team team { get; set; }
        public required Fixture fixture { get; set; }
        public required Statistics.League league { get; set; }

    }
}
