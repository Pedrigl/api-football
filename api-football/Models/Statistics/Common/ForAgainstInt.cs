using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace api_football.Models.Statistics.Common
{
    public class ForAgainstInt
    {
        [JsonPropertyName("for")]
        public int _for { get; set; }

        public int against { get; set; }
    }
}
