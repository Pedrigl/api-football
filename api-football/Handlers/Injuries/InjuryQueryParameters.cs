namespace api_football.Handlers.Injuries
{
    public class InjuryQueryParameters
    {
        public int? League { get; set; }
        public int? Season { get; set; }
        public int? Fixture { get; set; }
        public int? Team { get; set; }
        public int? Player { get; set; }
        public string? Date { get; set; }
        public string? Timezone { get; set; }
    }
}