namespace api_football.Models.Injuries
{
    public class Fixture
    {
        public Fixture()
        {
        }
        public int id { get; set; }
        public string? timezone { get; set; }
        public DateTime? date { get; set; }
        public long timestamp { get; set; }
    }
}
