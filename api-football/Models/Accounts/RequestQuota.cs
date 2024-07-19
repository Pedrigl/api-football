using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Account
{
    public class RequestQuota
    {
        internal RequestQuota() { }
        public int current { get; set; }
        public int limit_day { get; set; }
    }
}
