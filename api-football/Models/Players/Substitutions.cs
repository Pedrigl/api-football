using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace api_football.Models.Players
{
    public class Substitutions
    {
        internal Substitutions()
        {
        }
        [JsonProperty("in")]
        public int _in { get; set; }
        [JsonProperty("out")]
        public int _out { get; set; }
        public int bench { get; set; }
    }
}
