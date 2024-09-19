using api_football.Models.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Coaches
{
    public class CoachingJob
    {
        public CoachingJob()
        {
        }
        public required Team team { get; set; }
        public required string start { get; set; }
        public string? end { get; set; }
    }
}
