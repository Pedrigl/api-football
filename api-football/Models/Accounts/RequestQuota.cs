using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Accounts
{
    public class RequestQuota
    {
        public RequestQuota() { }
        public int current { get; set; }
        public int limit_day { get; set; }
    }
}
