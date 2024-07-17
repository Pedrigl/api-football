using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Teams
{
    internal class Team
    {
        public required TeamInfo team { get; set; }
        public required Venue venue { get; set; }
    }
}
