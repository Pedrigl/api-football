using api_football.Models.Season;

namespace api_football.Models.League
{
    public class League
    {
        public required LeagueInfo league { get; set; }
        public required Country country { get; set; }
        public required SeasonInfo[] seasons { get; set; }
    }
}
