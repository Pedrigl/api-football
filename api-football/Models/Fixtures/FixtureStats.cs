using api_football.Models.Common;
using api_football.Models.Statistics;

namespace api_football.Models.Fixtures
{
    public class FixtureStats
    {
        public required Team team { get; set; }
        public TypeValuePair<int>[]? statistics { get; set; }
    }
}
