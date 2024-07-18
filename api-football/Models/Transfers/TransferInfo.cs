using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Transfers
{
    public class TransferInfo
    {
        public required string date { get; set; }
        public required string type { get; set; }
        public required TransferTeams teams { get; set; }
    }
}
