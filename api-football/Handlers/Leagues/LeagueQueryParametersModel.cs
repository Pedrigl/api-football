namespace api_football.Handlers.Leagues
{
    public class LeagueQueryParameters
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Country { get; set; }
        public string? Code { get; set; }
        public int? Season { get; set; }
        public int? Team { get; set; }
        public string? Type { get; set; }
        public string? Current { get; set; }
        public string? Search { get; set; }
        public int? Last { get; set; }
    }
}