﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Fixtures.PlayersStatistics
{
    public class GamesPlayed
    {
        internal GamesPlayed()
        {
        }
        public int minutes { get; set; }
        public int? number { get; set; }
        public string? position { get; set; }
        public string? rating { get; set; }
        public bool captain { get; set; }
        public bool substitute { get; set; }
    }
}
