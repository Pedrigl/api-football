using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace api_football.Models.Statistics.Goals
{
    public class GoalsScored
    {
        [JsonPropertyName("for")]
        public required GoalDetails _for { get; set; }
        public required GoalDetails against { get; set; }
    }
}
