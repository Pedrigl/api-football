using api_football.Models.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Players
{
    public class PlayerInfo : Person
    {
        internal PlayerInfo()
        {
        }
        public bool injured { get; set; }
    }
}
