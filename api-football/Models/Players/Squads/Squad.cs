using api_football.Models.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Players.Squads
{
    public class Squad
    {
        public required Team team { get; set; }
        public required SquadPlayer[] players { get; set; }
    }
}
