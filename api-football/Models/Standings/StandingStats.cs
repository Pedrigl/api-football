using api_football.Models.Common;

namespace api_football.Models.Standing
{
    public class StandingStats
    {
        public StandingStats()
        {
        }
        public int played { get; set; }
        public int win { get; set; }
        public int draw { get; set; }
        public int lose { get; set; }
        public required GenericForAgainst<int> goals { get; set; }
    }
}
