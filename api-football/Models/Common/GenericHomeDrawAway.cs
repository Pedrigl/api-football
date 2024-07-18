using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Common
{
    public class GenericHomeDrawAway <T> : GenericHomeAway<T>
    {
        public required T draw { get; set; }
    }
}
