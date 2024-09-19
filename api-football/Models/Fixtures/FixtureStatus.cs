using Newtonsoft.Json;
namespace api_football.Models.Fixtures
{
    public class FixtureStatus
    {
        public FixtureStatus()
        {
        }
        [JsonProperty("long")]
        public string? _long { get; set; }
        [JsonProperty("short")]
        public string? _short { get; set; }
        public int elapsed { get; set; }
    }
}
