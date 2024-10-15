using api_football.Models.Common;

namespace api_football.Models.Odds.Live
{
    public class OddInfo : IdNameTuple
    {
        public OddInfo()
        {
        }
        public required OddValue[] values { get; set; }
    }
}
