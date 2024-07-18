using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Statistics
{
    internal class AverageGoals
    {
        public required string Home { get; set; }
        public required string Away { get; set; }
        public required string Total { get; set; }
    }
}
