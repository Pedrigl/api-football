using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Accounts
{
    public class Subscription
    {
        internal Subscription() { }
        public required string plan { get; set; }
        public DateTime end { get; set; }
        public bool active { get; set; }
    }
}
