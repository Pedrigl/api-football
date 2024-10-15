using api_football.Models.Common;

namespace api_football.Models.Fixtures.Lineups
{
    public class LineupCoach : IdNameTuple
    {
        public LineupCoach() { }
        public string? photo { get; set; }
    }
}
