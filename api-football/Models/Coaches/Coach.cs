using api_football.Models.Persons;
using api_football.Models.Statistics;

namespace api_football.Models.Coaches
{
    public class Coach : Person
    {
        public required Team team { get; set; }
        public required CoachingJob[] career { get; set; }
    }
}
