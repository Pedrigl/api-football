using api_football.Models.Statistics;

namespace api_football.Models.Fixtures.Lineups
{
    public class LineupTeam : Team
    {
        public LineupTeam() { }
        public LineupColors? colors { get; set; }
    }
}
