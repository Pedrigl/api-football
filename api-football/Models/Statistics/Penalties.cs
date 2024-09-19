using api_football.Models.Common;

namespace api_football.Models.Statistics
{
    public class Penalties
    {
        public Penalties()
        {
        }
        public required TotalPercentage scored { get; set; }
        public required TotalPercentage missed { get; set; }
        public int total { get; set; }
    }
}
