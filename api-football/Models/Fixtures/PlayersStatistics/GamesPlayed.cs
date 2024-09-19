namespace api_football.Models.Fixtures.PlayersStatistics
{
    public class GamesPlayed
    {
        public GamesPlayed()
        {
        }
        public int minutes { get; set; }
        public int? number { get; set; }
        public string? position { get; set; }
        public string? rating { get; set; }
        public bool captain { get; set; }
        public bool substitute { get; set; }
    }
}
