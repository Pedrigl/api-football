using api_football.Models.Odds.Live;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Odds.PreGame.Mapping
{
    public class Mapping
    {
        public required OddLeague league { get; set; }
        public required MappingFixture fixture { get; set; }
        public DateTime update { get; set; }
    }
}
