using api_football.Models.Common;

namespace api_football.Models.Fixtures.Lineups
{
    public class LineupPlayer : IdNameTuple
    {
        public LineupPlayer() { }
        public int number { get; set; }
        public string? pos { get; set; }
        public string? grid { get; set; }
    }
}
