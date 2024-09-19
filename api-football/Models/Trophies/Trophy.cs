namespace api_football.Models.Trophies
{
    public class Trophy
    {
        public required string league { get; set; }
        public required string country { get; set; }
        public required string season { get; set; }
        public required string place { get; set; }
    }
}
