namespace api_football.Handlers.Fixtures
{
    public class FixtureQueryParameters
    {
        public int? Id { get; set; }
        public string? Ids { get; set; }
        public string? Live { get; set; }
        public string? Date { get; set; }
        public required int League { get; set; }
        public required int Season { get; set; }
        public int? Team { get; set; }
        public int? Last { get; set; }
        public int? Next { get; set; }
        public string? From { get; set; }
        public string? To { get; set; }
        public string? Round { get; set; }
        public string? Status { get; set; }
        public int? Venue { get; set; }
        public string? Timezone { get; set; }
    }
    
    public class H2HFixtureQueryParameters
    {
        public string H2H { get; set; }
        public string? Date { get; set; }
        public int? League { get; set; }
        public int? Season { get; set; }
        public int? Last { get; set; }
        public int? Next { get; set; }
        public string? From { get; set; }
        public string? To { get; set; }
        public string? Status { get; set; }
        public int? Venue { get; set; }
        public string? Timezone { get; set; }
    }

    // Classes adicionais para outros métodos
    public class FixtureQueryParams
    {
        public int Fixture { get; set; }
        public int? Team { get; set; }
        public string? Type { get; set; }
    }

    public class FixtureEventQueryParams
    {
        public int Fixture { get; set; }
        public int? Team { get; set; }
        public string? Player { get; set; }
        public string? Type { get; set; }
    }

    public class FixtureLineupQueryParams
    {
        public int Fixture { get; set; }
        public int? Team { get; set; }
        public int? Player { get; set; }
        public string? Type { get; set; }
    }

    public class FixturePlayerStatsQueryParams
    {
        public int Fixture { get; set; }
        public int? Team { get; set; }
    }
}