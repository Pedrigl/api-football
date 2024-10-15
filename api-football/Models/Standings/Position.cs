using api_football.Models.Statistics;

namespace api_football.Models.Standings
{
    public class Position
    {
        public int rank { get; set; }
        public required Team team { get; set; }
        public int points { get; set; }
        public int goalsDiff { get; set; }
        public required string group { get; set; }
        public required string form { get; set; }
        public required string status { get; set; }
        public required string description { get; set; }
        public required StandingStats all { get; set; }
        public required StandingStats home { get; set; }
        public required StandingStats away { get; set; }
        public DateTime update { get; set; }
    }
}
