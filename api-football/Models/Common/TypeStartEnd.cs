﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Common
{
    public class TypeStartEnd
    {
        internal TypeStartEnd()
        {
        }
        public required string type { get; set; }
        public required string start { get; set; }
        public required string end { get; set; }
    }
}