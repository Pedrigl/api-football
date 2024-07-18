using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Statistics.Goals
{
    internal class Goals
    {
        public required GoalDetails For { get; set; }
        public required GoalDetails Against { get; set; }
    }
}
