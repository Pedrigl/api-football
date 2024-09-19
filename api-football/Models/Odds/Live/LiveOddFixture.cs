using api_football.Models.Fixtures;

namespace api_football.Models.Odds.Live
{
    public class LiveOddFixture
    {
        public LiveOddFixture()
        {
        }
        public int id { get; set; }
        public required FixtureStatus status { get; set; }
    }
}
