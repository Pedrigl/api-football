using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Trophies
{
    public class Trophy
    {
        public required string league { get; set; }
        public required string country { get; set; }
        public required string season { get; set; }
        public required string place { get; set; }
    }
}
