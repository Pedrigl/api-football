using api_football.Models.Persons;

namespace api_football.Models.Players
{
    public class PlayerInfo : Person
    {
        public PlayerInfo()
        {
        }
        public bool injured { get; set; }
    }
}
