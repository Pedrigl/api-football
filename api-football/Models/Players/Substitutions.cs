using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace api_football.Models.Players
{
    public class Substitutions
    {
        internal Substitutions()
        {
        }
        [JsonPropertyName("in")]
        public int _in { get; set; }
        [JsonPropertyName("out")]
        public int _out { get; set; }
        public int bench { get; set; }
    }
}
