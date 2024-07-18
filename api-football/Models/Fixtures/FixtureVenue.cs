using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Fixtures
{
    public class FixtureVenue
    {
        public int id { get; set; }
        public required string name { get; set; }
        public required string city { get; set; }
    }
}
