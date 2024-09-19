using api_football.Models.Odds.Live;

namespace api_football.Models.Odds.PreGame.Mapping
{
    public class Mapping
    {
        public required OddLeague league { get; set; }
        public required MappingFixture fixture { get; set; }
        public DateTime update { get; set; }
    }
}
