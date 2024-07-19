using api_football.Models.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Fixtures.PlayerStatistics
{
    public class PlayersStatisticsTeam : Team
    {
        internal PlayersStatisticsTeam()
        {
        }
        public DateTime update { get; set; }
    }
}
