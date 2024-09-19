using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Common
{
    public class GenericHomeAwayTotal <T> : GenericHomeAway<T>
    {
        public GenericHomeAwayTotal()
        {
        }
        public required T total { get; set; }
    }
}
