using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models
{
    public class TeamVenue
    {
        public int id { get; set; }
        public required string name { get; set; }
        public required string address { get; set; }
        public required string city { get; set; }
        public int capacity { get; set; }
        public required string surface { get; set; }
        public required string image { get; set; }
    }
}
