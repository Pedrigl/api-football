using api_football.Models.Common;

namespace api_football.Models.Fixtures
{
    public class FixtureScore
    {
        public FixtureScore()
        {
        }
        public GenericHomeAway<int?> halftime { get; set; }
        public GenericHomeAway<int?> fulltime { get; set; }
        public GenericHomeAway<int?> extratime { get; set; }
        public GenericHomeAway<int?> penalty { get; set; }
    }
}
