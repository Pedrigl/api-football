namespace api_football.Models.Predictions
{
    public class PredictedResult
    {
        public PredictedResult() { }
        public int id { get; set; }
        public required string name { get; set; }
        public required string commnet { get; set; }
    }
}
