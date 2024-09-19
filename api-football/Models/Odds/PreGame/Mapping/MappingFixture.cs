using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Odds.PreGame.Mapping
{
    public class MappingFixture
    {
        public MappingFixture()
        {
        }
        public int id { get; set; }
        public DateTime date { get; set; }
        public long timestamp { get; set; }
    }
}
