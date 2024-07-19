using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Common
{
    public class GenericTotalAverage <Tt,Ta>
    {
        internal GenericTotalAverage()
        {
        }
        public required Tt total { get; set; }
        public required Ta average { get; set; }
    }
}
