using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace api_football.Models.Statistics
{
    public class TeamStatistics
    {
        public required League league { get; set; }
        public required Team team { get; set; }
        public required string form { get; set; }
        public required Fixtures fixtures { get; set; } 

    }
}
