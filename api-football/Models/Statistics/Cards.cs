using api_football.Models.Common;

namespace api_football.Models.Statistics
{
    public class Cards
    {
        public Cards()
        {
        }
        public required MinutesTracking yellow { get; set; }
        public required MinutesTracking red { get; set; }
    }
}
