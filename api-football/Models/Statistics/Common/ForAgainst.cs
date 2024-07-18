using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace api_football.Models.Statistics.Common
{
    public class ForAgainst
    {
        [JsonPropertyName("for")]
        public required HomeAwayInt _for { get; set; }
        public required HomeAwayInt against { get; set; }
    }
}
