using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Season
{
    public class SeasonCoverage
    {
        public SeasonCoverage()
        {
        }
        public required SeasonCoverageFixtures fixtures { get; set; }
        public bool standings { get; set; }
        public bool players { get; set; }
        public bool top_scorers { get; set; }
        public bool top_assists { get; set; }
        public bool top_cards { get; set; }
        public bool injuries { get; set; }
        public bool predictions { get; set; }
        public bool odds { get; set; }
    }
}
