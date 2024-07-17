using api_football.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models
{
    internal class Country
    {
        public required string name { get; set; }
        public required string code { get; set; }
        public required string flag { get; set; }
    }
}
