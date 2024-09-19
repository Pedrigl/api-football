using api_football.Models.Common;

namespace api_football.Models.Statistics
{
    public class Biggest
    {
        public Biggest()
        {
        }
        public required GenericWinDrawLoss<int> streak { get; set; }
        public required GenericHomeAway<string> wins { get; set; }
        public required GenericHomeAway<string> loses { get; set; }
        public required GenericForAgainst<GenericHomeAway<int>> goals { get; set; }
    }
}
