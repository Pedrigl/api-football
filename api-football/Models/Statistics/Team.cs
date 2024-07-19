using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Statistics
{
    public class Team
    {
        internal Team()
        {
        }
        public int id { get; set; }
        public required string name { get; set; }
        public required string logo { get; set; }
    }
}
