using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Fixtures
{
    public class FixtureInfo
    {
        public int id { get; set; }
        public string? referee { get; set; }
        public string? timezone { get; set; }
        public DateTime? date { get; set; }
        public long timestamp { get; set; }
        public required Periods periods { get; set; }
        public required FixtureVenue venue { get; set; }
        public required FixtureStatus status { get; set; }
    }
}
