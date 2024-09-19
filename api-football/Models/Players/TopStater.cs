using StatisticsClass = api_football.Models.Fixtures.PlayersStatistics.Stats.Statistics;


namespace api_football.Models.Players
{
    public class TopStater
    {
        public required PlayerInfo player { get; set; }
        public required StatisticsClass[] statistics { get; set; }
    }
}
