using api_football.Models.Statistics;

namespace api_football.Models.Coaches
{
    public class CoachingJob
    {
        public CoachingJob()
        {
        }
        public required Team team { get; set; }
        public required string start { get; set; }
        public string? end { get; set; }
    }
}
