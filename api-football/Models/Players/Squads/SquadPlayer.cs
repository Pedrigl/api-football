using api_football.Models.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Players.Squads
{
    public class SquadPlayer : PersonInfo
    {
        public int age { get; set; }
        public int number { get; set; }
        public required string position { get; set; }
    }
}
