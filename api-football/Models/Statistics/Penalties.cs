using api_football.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Statistics
{
    public class Penalties
    {
        internal Penalties()
        {
        }
        public required TotalPercentage scored { get; set; }
        public required TotalPercentage missed { get; set; }
        public int total { get; set; }
    }
}
