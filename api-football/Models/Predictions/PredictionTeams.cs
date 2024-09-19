namespace api_football.Models.Predictions
{
    public class PredictionTeams
    {
        public PredictionTeams()
        {
        }
        public required PredictionTeamInfo home { get; set; }
        public required PredictionTeamInfo away { get; set; }
    }
}
