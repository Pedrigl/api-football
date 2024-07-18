using api_football.Models.Persons;
using api_football.Models.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Coachs
{
    public class Coach : Person
    {
        public required Team team { get; set; }
        public required CoachingJob[] career { get; set; }
    }
}
