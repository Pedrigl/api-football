namespace api_football.Models.Fixtures
{
    public class FixtureLeague : Statistics.League
    {
        public FixtureLeague()
        {
        }
        public required string round { get; set; }
    }
}
