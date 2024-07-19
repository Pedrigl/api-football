using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Account
{
    public class AccountInfo
    {
        internal AccountInfo() { }
        public required string firstname { get; set; }
        public required string lastname { get; set; }
        public required string email { get; set; }
    }
}
