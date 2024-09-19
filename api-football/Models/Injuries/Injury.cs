using api_football.Models.Statistics;

namespace api_football.Models.Injuries
{
    public class Injury
    {
        public required PlayerInjured player { get; set; }
        public required Team team { get; set; }
        public required Fixture fixture { get; set; }
        public required Statistics.League league { get; set; }

    }
}
