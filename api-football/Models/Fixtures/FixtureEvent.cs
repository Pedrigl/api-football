using api_football.Models.Common;
using api_football.Models.Statistics;

namespace api_football.Models.Fixtures
{
    public class FixtureEvent
    {
        public FixtureEvent()
        {
        }
        public required Time time { get; set; }
        public required Team team { get; set; }
        public required IdNameTuple player { get; set; }
        public required IdNameTuple assist { get; set; }
        public required string type { get; set; }
        public required string detail { get; set; }
        public string? comments { get; set; }
    }
}
