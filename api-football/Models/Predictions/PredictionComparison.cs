using api_football.Models.Common;

namespace api_football.Models.Predictions
{
    public class PredictionComparison
    {
        public PredictionComparison()
        {
        }
        public required GenericHomeAway<string> form { get; set; }
        public required GenericHomeAway<string> att { get; set; }
        public required GenericHomeAway<string> def { get; set; }
        public required GenericHomeAway<string> poisson_distribution { get; set; }
        public required GenericHomeAway<string> h2h { get; set; }
        public required GenericHomeAway<string> goals { get; set; }
        public required GenericHomeAway<string> total { get; set; }
    }
}
