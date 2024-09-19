namespace api_football.Models.Statistics
{
    public class Team
    {
        public Team()
        {
        }
        public int id { get; set; }
        public required string name { get; set; }
        public required string logo { get; set; }
    }
}
