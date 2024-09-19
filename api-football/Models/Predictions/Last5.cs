using api_football.Models.Common;

namespace api_football.Models.Predictions
{
    public class Last5
    {
        public Last5()
        {
        }
        public required string form { get; set; }
        public required string att { get; set; }
        public required string def { get; set; }
        public required GenericForAgainst<GenericTotalAverage<int, double>> goals { get; set; }
    }
}
