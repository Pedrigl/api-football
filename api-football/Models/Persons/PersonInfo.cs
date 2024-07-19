using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Persons
{
    public class PersonInfo : IdNameTuple
    {
        internal PersonInfo()
        {
        }
        public string? photo { get; set; }
    }
}
