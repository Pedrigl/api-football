using api_football.Models.League;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Statistics
{
    public class League 
    {
        public int id { get; set; }
        public required string name { get; set; }
        public required string country { get; set; }
        public required string logo { get; set; }
        public required string flag { get; set; }
        public int season { get; set; }
    }
}
