using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace api_football.Models.Statistics.Biggest
{
    internal class MostGoals
    {
        [JsonPropertyName("for")]
        public required GoalsScored _for { get; set; }
        public required GoalsScored against { get; set; }
    }
}
