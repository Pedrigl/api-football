using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Common
{
    public class Birth
    {
        public Birth()
        {
        }
        public required string date { get; set; }
        public required string place { get; set; }
        public required string country { get; set; }
    }
}
