using api_football.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Predictions
{
    public class PredictionsInfo
    {
        public required PredictedResult winner { get; set; }
        public bool win_or_draw { get; set; }
        public string? under_over_15 { get; set; }
        public GenericHomeAway<string>? goals { get; set; }
        public string? advice { get; set; }
        public GenericHomeDrawAway<string>? percent { get; set; }
    }
}
