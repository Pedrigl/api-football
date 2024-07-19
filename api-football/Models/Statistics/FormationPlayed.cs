using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Statistics
{
    public class FormationPlayed
    {
        internal FormationPlayed()
        {
        }
        public required string formation { get; set; }
        public int played { get; set; }
    }
}
