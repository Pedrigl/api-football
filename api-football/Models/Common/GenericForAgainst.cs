using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace api_football.Models.Common
{
    public class GenericForAgainst <T> 
    {
        internal GenericForAgainst()
        {
        }
        [JsonPropertyName("for")]
        public required T _for { get; set; }
        public required T against { get; set; }
    }
}
