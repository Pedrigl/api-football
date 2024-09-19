using api_football.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Statistics
{
    public class Cards
    {
        public Cards()
        {
        }
        public required MinutesTracking yellow { get; set; }
        public required MinutesTracking red { get; set; }
    }
}
