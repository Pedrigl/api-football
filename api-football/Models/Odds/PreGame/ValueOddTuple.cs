using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Odds.PreGame
{
    public class ValueOddTuple
    {
        public ValueOddTuple()
        {
        }
        public int value { get; set; }
        public required string odd { get; set; }
    }
}
