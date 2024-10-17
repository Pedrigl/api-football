namespace api_football.Handlers.Players
{
    public class PlayerQueryParameters
    {
        public long? Id { get; set; }
        public int? Team { get; set; }
        public int? League { get; set; }
        public int? Season { get; set; }
        public string? Search { get; set; }
        public int? Page { get; set; }
    }

    public class SquadQueryParameters
    {
        public int? Id { get; set; }
        public int? Team { get; set; }
    }

    public class TopStatQueryParameters
    {
        public int League { get; set; }
        public int Season { get; set; }
    }
}