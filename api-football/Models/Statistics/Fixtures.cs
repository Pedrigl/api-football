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
        public required HomeAwayTotalInt played { get; set; }
        public required HomeAwayTotalInt wins { get; set; }
        public required HomeAwayTotalInt draws { get; set; }
        public required HomeAwayTotalInt loses { get; set; }
    }
}
