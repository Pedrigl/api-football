using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Odds.Live
{
    public class OddInfo : IdNameTuple
    {
        internal OddInfo()
        {
        }
        public required OddValue[] values { get; set; }
    }
}
