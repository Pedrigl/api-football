using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using api_football.Models.Common;

namespace api_football.Models.Statistics.Goals
{
    public class GoalDetails
    {
        public GoalDetails()
        {
        }
        public required GenericHomeAwayTotal<int> total { get; set; }
        public required GenericHomeAwayTotal<string> average { get; set; }
        public required MinutesTracking minute { get; set; }
    }
}
