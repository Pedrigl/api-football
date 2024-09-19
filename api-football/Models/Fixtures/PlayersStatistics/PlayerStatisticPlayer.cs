using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using api_football.Models.Persons;

namespace api_football.Models.Fixtures.PlayersStatistics
{
    public class PlayerStatisticPlayer
    {
        public PlayerStatisticPlayer()
        {
        }
        public required PersonInfo player { get; set; }
        public required Stats.Statistics[] statistics { get; set; }
    }
}
