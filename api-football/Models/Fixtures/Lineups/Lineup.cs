namespace api_football.Models.Fixtures.Lineups
{
    public class Lineup
    {
        public required LineupTeam team { get; set; }
        public string? formation { get; set; }
        public required LineupPlayerInfo[] startXI { get; set; }
        public required LineupPlayerInfo[] substitutes { get; set; }
        public required LineupCoach coach { get; set; }

    }
}
