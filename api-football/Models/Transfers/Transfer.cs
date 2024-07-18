using api_football.Models.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Transfers
{
    public class Transfer
    {
        public required IdNameTuple player { get; set; }
        public DateTime update { get; set; }
        public required TransferInfo[] transfers { get; set; }
    }
}
