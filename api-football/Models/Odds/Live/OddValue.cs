namespace api_football.Models.Odds.Live
{
    public class OddValue
    {
        public OddValue()
        {
        }
        public required string value { get; set; }
        public required string odd { get; set; }
        public required string handicap { get; set; }
        public bool? main { get; set; }
        public bool? suspended { get; set; }
    }
}
