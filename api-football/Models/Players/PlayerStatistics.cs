using api_football.Models.Fixtures.PlayersStatistics.Stats;
using api_football.Models.Statistics;
using Cards = api_football.Models.Fixtures.PlayersStatistics.Stats.Cards;
using Penalties = api_football.Models.Fixtures.PlayersStatistics.Stats.Penalties;

namespace api_football.Models.Players
{
    public class PlayerStatistics
    {
        public PlayerStatistics()
        {
        }
        public required Team team { get; set; }
        public required Statistics.League league { get; set; }
        public required SeasonPlayed games { get; set; }
        public required Substitutions substitutes { get; set; }
        public required Shots shots { get; set; }
        public required Goals goals { get; set; }
        public required Passes passes { get; set; }
        public required Tackles tackles { get; set; }
        public required Duels duels { get; set; }
        public required Dribbles dribbles { get; set; }
        public required Fouls fouls { get; set; }
        public required Cards cards { get; set; }
        public required Penalties penalty { get; set; }
    }
}
