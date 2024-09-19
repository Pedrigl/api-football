using api_football.Models.Statistics;
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
