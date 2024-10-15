namespace api_football.Handlers.Coaches
{
    public class CoachQueryParameters
    {
        public int? Id { get; set; }
        public int? Team { get; set; }
        public string? Search { get; set; }
    }
}