using api_football.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Predictions
{
    public class Last5
    {
        internal Last5()
        {
        }
        public required string form { get; set; }
        public required string att { get; set; }
        public required string def { get; set; }
        public required GenericForAgainst<GenericTotalAverage<int,double>> goals { get; set; }
    }
}
