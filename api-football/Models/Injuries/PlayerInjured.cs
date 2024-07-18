using api_football.Models.Fixtures.PlayersStatistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Injuries
{
    public class PlayerInjured : PlayerInfo
    {
        public string? type { get; set; }
        public string? reason { get; set; }
    }
}
