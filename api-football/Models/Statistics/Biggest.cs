﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using api_football.Models.Common;

namespace api_football.Models.Statistics
{
    public class Biggest
    {
        internal Biggest()
        {
        }
        public required GenericWinDrawLoss<int> streak { get; set; }
        public required GenericHomeAway<string> wins { get; set; }
        public required GenericHomeAway<string> loses { get; set; }
        public required GenericForAgainst<GenericHomeAway<int>> goals { get; set; }
    }
}
