using api_football.Models.Persons;

namespace api_football.Models.Players.Squads
{
    public class SquadPlayer : PersonInfo
    {
        public SquadPlayer()
        {
        }
        public int age { get; set; }
        public int number { get; set; }
        public required string position { get; set; }
    }
}
