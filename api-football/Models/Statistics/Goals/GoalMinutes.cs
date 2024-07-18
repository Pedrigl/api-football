﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace api_football.Models.Statistics.Goals.Goals
{
    internal class GoalMinutes
    {
        [JsonPropertyName("0-15")]
        public required GoalMinuteDetails _0_15 { get; set; }

        [JsonPropertyName("16-30")]
        public required GoalMinuteDetails _16_30 { get; set; }

        [JsonPropertyName("31-45")]
        public required GoalMinuteDetails _31_45 { get; set; }

        [JsonPropertyName("46-60")]
        public required GoalMinuteDetails _46_60 { get; set; }

        [JsonPropertyName("61-75")]
        public required GoalMinuteDetails _61_75 { get; set; }

        [JsonPropertyName("76-90")]
        public required GoalMinuteDetails _76_90 { get; set; }

        [JsonPropertyName("91-105")]
        public required GoalMinuteDetails _91_105 { get; set; }

        [JsonPropertyName("106-120")]
        public required GoalMinuteDetails _106_120 { get; set; }
    }
}