using Newtonsoft.Json;
namespace api_football.Models.Common
{
    public class GenericForAgainst<T>
    {
        public GenericForAgainst()
        {
        }
        [JsonProperty("for")]
        public required T _for { get; set; }
        public required T against { get; set; }
    }
}
