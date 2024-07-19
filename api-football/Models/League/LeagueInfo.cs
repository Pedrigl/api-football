using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.League
{
    public class LeagueInfo
    {
        public int id { get; set; }
        public required string name { get; set; }
        public required string type { get; set; }
        public required string logo { get; set; }
    }
}
