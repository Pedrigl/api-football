using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Common
{
    public class GenericHomeAway <T>
    {
        internal GenericHomeAway()
        {
        }
        public required T home { get; set; }
        public required T away { get; set; }
    }
}
