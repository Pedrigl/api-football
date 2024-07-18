using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Statistics.Common
{
    public class HomeAwayTotalStr
    {
        public required string home { get; set; }
        public required string away { get; set; }
        public required string total { get; set; }
    }
}
