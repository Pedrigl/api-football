﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Odds.Live
{
    public class OddLeague
    {
        internal OddLeague()
        {
        }
        public int id { get; set; }
        public int season { get; set; }
    }
}