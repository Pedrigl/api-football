using api_football.Models.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Injuries
{
    public class PlayerInjured : PersonInfo
    {
        internal PlayerInjured()
        {
        }
        public string? type { get; set; }
        public string? reason { get; set; }
    }
}
