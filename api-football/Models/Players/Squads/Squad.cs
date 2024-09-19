using api_football.Models.Statistics;

namespace api_football.Models.Players.Squads
{
    public class Squad
    {
        public required Team team { get; set; }
        public required SquadPlayer[] players { get; set; }
    }
}
