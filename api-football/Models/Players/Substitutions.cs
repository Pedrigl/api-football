using Newtonsoft.Json;
namespace api_football.Models.Players
{
    public class Substitutions
    {
        public Substitutions()
        {
        }
        [JsonProperty("in")]
        public int _in { get; set; }
        [JsonProperty("out")]
        public int _out { get; set; }
        public int bench { get; set; }
    }
}
