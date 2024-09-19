namespace api_football.Models.Statistics
{
    public class League
    {
        public League()
        {
        }
        public int id { get; set; }
        public required string name { get; set; }
        public required string country { get; set; }
        public required string logo { get; set; }
        public required string flag { get; set; }
        public int season { get; set; }
    }
}
