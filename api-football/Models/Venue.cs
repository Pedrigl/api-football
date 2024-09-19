namespace api_football.Models
{
    public class Venue
    {
        public int id { get; set; }
        public required string name { get; set; }
        public required string address { get; set; }
        public required string city { get; set; }
        public required string country { get; set; }
        public int capacity { get; set; }
        public required string surface { get; set; }
        public required string image { get; set; }
    }
}
