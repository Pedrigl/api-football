﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Root
{
    public class Paging
    {
        internal Paging()
        {
        }
        public int current { get; set; }
        public int total { get; set; }
    }
}
