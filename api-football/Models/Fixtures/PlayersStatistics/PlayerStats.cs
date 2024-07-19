using api_football.Models.Fixtures.PlayersStatistics.Stats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Fixtures.PlayersStatistics
{
    public class PlayerStats
    {
        public required PlayersStatisticsTeam team { get; set; }
        public required PlayerStatisticPlayer[] players { get; set; }
    }
}
