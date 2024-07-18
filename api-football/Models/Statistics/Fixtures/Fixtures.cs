using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Statistics.Fixtures
{
    internal class Fixtures
    {
        public required HomeAwayTotalInt played { get; set; }
        public required HomeAwayTotalInt wins { get; set; }
        public required HomeAwayTotalInt draws { get; set; }
        public required HomeAwayTotalInt loses { get; set; }
    }
}
