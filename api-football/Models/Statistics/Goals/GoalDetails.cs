using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using api_football.Models.Statistics.Common;

namespace api_football.Models.Statistics.Goals
{
    public class GoalDetails
    {
        public required HomeAwayTotalInt total { get; set; }
        public required HomeAwayTotalStr average { get; set; }
        public required MinutesTracking minute { get; set; }
    }
}
