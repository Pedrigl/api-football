﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Statistics
{
    internal class GoalMinuteDetails
    {
        public int minute { get; set; }
        public required string percentage { get; set; }
    }
}
