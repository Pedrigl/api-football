using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace api_football.Models.Common
{
    public class MinutesTracking
    {
        public MinutesTracking()
        {
        }
        [JsonProperty("0-15")]
        public required MinutePercentageDetails _0_15 { get; set; }

        [JsonProperty("16-30")]
        public required MinutePercentageDetails _16_30 { get; set; }

        [JsonProperty("31-45")]
        public required MinutePercentageDetails _31_45 { get; set; }

        [JsonProperty("46-60")]
        public required MinutePercentageDetails _46_60 { get; set; }

        [JsonProperty("61-75")]
        public required MinutePercentageDetails _61_75 { get; set; }

        [JsonProperty("76-90")]
        public required MinutePercentageDetails _76_90 { get; set; }

        [JsonProperty("91-105")]
        public required MinutePercentageDetails _91_105 { get; set; }

        [JsonProperty("106-120")]
        public required MinutePercentageDetails _106_120 { get; set; }
    }
}
