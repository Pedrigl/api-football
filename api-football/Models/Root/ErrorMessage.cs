using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Root
{
    public class ErrorMessage
    {
        internal ErrorMessage()
        {
        }
        public required string message { get; set; }
    }
}
