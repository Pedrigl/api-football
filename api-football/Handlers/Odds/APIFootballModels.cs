namespace api_football.Handlers.Odds
{
    public class LiveOddQueryParameters
    {
        public int? Fixture { get; set; }
        public int? League { get; set; }
        public int? Bet { get; set; }
    }

    public class PreGameOddQueryParameters
    {
        public int? Fixture { get; set; }
        public int? League { get; set; }
        public int? Season { get; set; }
        public string? Date { get; set; }
        public string? Timezone { get; set; }
        public int? Page { get; set; }
        public int? Bookmaker { get; set; }
        public int? Bet { get; set; }
    }

    public class AvailableBetQueryParameters
    {
        public string? Id { get; set; }
        public string? Search { get; set; }
    }

    public class MappingQueryParameters
    {
        public int? Page { get; set; }
    }
}