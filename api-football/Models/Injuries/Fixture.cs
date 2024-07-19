using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Injuries
{
    public class Fixture
    {
        internal Fixture()
        {
        }
        public int id { get; set; }
        public string? timezone { get; set; }
        public DateTime? date { get; set; }
        public long timestamp { get; set; }
    }
}
