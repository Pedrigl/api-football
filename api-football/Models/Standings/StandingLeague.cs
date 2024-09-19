using api_football.Models.Standing;

namespace api_football.Models.Standings
{
    public class StandingLeague : Statistics.League
    {
        public required List<List<Position>> standings { get; set; }
    }
}
