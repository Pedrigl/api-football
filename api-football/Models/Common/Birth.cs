namespace api_football.Models.Common
{
    public class Birth
    {
        public Birth()
        {
        }
        public required string date { get; set; }
        public required string place { get; set; }
        public required string country { get; set; }
    }
}
