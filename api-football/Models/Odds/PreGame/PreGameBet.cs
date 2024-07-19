using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Odds.PreGame
{
    public class PreGameBet : IdNameTuple
    {
        internal PreGameBet()
        {
        }
        public required ValueOddTuple[] values { get; set; }
    }
}
