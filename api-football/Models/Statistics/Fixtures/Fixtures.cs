using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Statistics.Fixtures
{
    internal class Fixtures
    {
        public required FixturesInfo played { get; set; }
        public required FixturesInfo wins { get; set; }
        public required FixturesInfo draws { get; set; }
        public required FixturesInfo loses { get; set; }
    }
}
