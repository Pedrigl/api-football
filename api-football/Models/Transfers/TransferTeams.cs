using api_football.Models.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace api_football.Models.Transfers
{
    public class TransferTeams
    {
        [JsonPropertyName("in")]
        public required Team _in { get; set; }
        [JsonPropertyName("out")]
        public required Team _out { get; set; }
    }
}
