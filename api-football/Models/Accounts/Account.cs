using api_football.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Accounts
{
    public class Account
    {
        internal Account() { }
        public required AccountInfo account { get; set; }
        public required Subscription subscription { get; set; }
        public required RequestQuota requests { get; set; }
    }
}
