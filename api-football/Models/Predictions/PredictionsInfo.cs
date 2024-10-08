﻿using api_football.Models.Common;

namespace api_football.Models.Predictions
{
    public class PredictionsInfo
    {
        public PredictionsInfo()
        {
        }
        public required PredictedResult winner { get; set; }
        public bool win_or_draw { get; set; }
        public string? under_over_15 { get; set; }
        public GenericHomeAway<string>? goals { get; set; }
        public string? advice { get; set; }
        public GenericHomeDrawAway<string>? percent { get; set; }
    }
}
