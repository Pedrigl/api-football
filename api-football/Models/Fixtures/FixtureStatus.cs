using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace api_football.Models.Fixtures
{
    public class FixtureStatus
    {
        [JsonPropertyName("long")]
        public string? _long { get; set; }
        [JsonPropertyName("short")]
        public string? _short { get; set; }
        public int elapsed { get; set; }
    }
}
