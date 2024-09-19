using api_football.Models.Statistics;

namespace api_football.Models.Predictions
{
    public class PredictionTeamInfo : Team
    {
        public PredictionTeamInfo()
        {
        }
        public Last5? last_5 { get; set; }
        public PredictionLeague? league { get; set; }
    }
}
