namespace api_football.Models.Fixtures
{
    public class FixtureMatch
    {
        public FixtureMatch()
        {
        }
        public required FixtureTeam home { get; set; }
        public required FixtureTeam away { get; set; }
    }
}
