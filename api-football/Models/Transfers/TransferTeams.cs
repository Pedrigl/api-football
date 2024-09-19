using api_football.Models.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace api_football.Models.Transfers
{
    public class TransferTeams
    {
        public TransferTeams()
        {
        }
        [JsonProperty("in")]
        public required Team _in { get; set; }
        [JsonProperty("out")]
        public required Team _out { get; set; }
    }
}
