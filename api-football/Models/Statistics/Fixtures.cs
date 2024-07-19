using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using api_football.Models.Common;

namespace api_football.Models.Statistics
{
    public class Fixtures
    {
        internal Fixtures()
        {
        }
        public required GenericHomeAwayTotal<int> played { get; set; }
        public required GenericHomeAwayTotal<int> wins { get; set; }
        public required GenericHomeAwayTotal<int> draws { get; set; }
        public required GenericHomeAwayTotal<int> loses { get; set; }
    }
}
