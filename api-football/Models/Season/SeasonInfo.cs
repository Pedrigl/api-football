using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Season
{
    public class SeasonInfo
    {
        public int year { get; set; }
        public required string start { get; set; }
        public required string end { get; set; }
        public bool current { get; set; }
        public required SeasonCoverage coverage { get; set; }
    }
}
