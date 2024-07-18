using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Fixtures.PlayersStatistics
{
    public class PlayerStatisticPlayer
    {
        public required PlayerInfo player { get; set; }
        public required Stats.Statistics[] statistics { get; set; }
    }
}
