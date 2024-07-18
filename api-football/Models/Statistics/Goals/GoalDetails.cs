using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Statistics.Goals
{
    internal class GoalDetails
    {
        public required HomeAwayTotalInt total { get; set; }
        public required AverageGoals average { get; set; }
        public required GoalMinutes minute { get; set; }
    }
}
