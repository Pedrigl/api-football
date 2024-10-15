namespace api_football.Handlers.Teams
{
    public class TeamInfoQueryParameters
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public int? League { get; set; }
        public int? Season { get; set; }
        public string? Country { get; set; }
        public string? Code { get; set; }
        public int? Venue { get; set; }
        public string? Search { get; set; }
    }

    public class TeamStatisticsQueryParameters
    {
        public int League { get; set; }
        public int Season { get; set; }
        public int Team { get; set; }
        public string Date { get; set; }
    }
}