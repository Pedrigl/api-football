using api_football.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Persons
{
    public class Person : PersonInfo
    {
        public required string firstname { get; set; }
        public required string lastname { get; set; }
        public int age { get; set; }
        public required Birth birth { get; set; }
        public required string nationality { get; set; }
        public required string height { get; set; }
        public required string weight { get; set; }
    }
}
