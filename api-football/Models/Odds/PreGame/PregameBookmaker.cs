﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Odds.PreGame
{
    public class PregameBookmaker : IdNameTuple
    {
        internal PregameBookmaker()
        {
        }
        public required PreGameBet[] bets { get; set; }
    }
}