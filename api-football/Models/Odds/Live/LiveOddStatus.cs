using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Odds.Live
{
    public class LiveOddStatus
    {
        internal LiveOddStatus()
        {
        }
        public bool? stopped { get; set; }
        public bool? blocked { get; set; }
        public bool? finished { get; set; }
    }
}
