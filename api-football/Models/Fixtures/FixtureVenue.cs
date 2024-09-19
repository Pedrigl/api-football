namespace api_football.Models.Fixtures
{
    public class FixtureVenue
    {
        public FixtureVenue()
        {
        }
        public int id { get; set; }
        public required string name { get; set; }
        public required string city { get; set; }
    }
}
