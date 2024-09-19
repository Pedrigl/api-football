using api_football.Models.Injuries;

namespace api_football.Models.Odds.PreGame
{
    public class PregameOdds
    {
        public required Statistics.League league { get; set; }
        public required Fixture fixture { get; set; }
        public DateTime update { get; set; }
        public required PregameBookmaker[] bookmakers { get; set; }
    }
}
