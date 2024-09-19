namespace api_football.Models.Fixtures.PlayersStatistics
{
    public class PlayerStats
    {
        public required PlayersStatisticsTeam team { get; set; }
        public required PlayerStatisticPlayer[] players { get; set; }
    }
}
