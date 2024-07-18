using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Common
{
    public class TypeValuePair<T>
    {
        public required string type { get; set; }
        public required T value { get; set; }
    }
}
