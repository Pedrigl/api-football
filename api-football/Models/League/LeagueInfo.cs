namespace api_football.Models.League
{
    public class LeagueInfo
    {
        public LeagueInfo()
        {
        }
        public int id { get; set; }
        public required string name { get; set; }
        public required string type { get; set; }
        public required string logo { get; set; }
    }
}
