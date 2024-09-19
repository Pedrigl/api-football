using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Common
{
    public class GenericWinDrawLoss <T>
    {
        public GenericWinDrawLoss()
        {
        }
        public required T wins { get; set; }
        public required T draws { get; set; }
        public required T loses { get; set; }
    }
}
