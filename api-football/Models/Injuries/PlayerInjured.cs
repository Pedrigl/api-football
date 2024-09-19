using api_football.Models.Persons;

namespace api_football.Models.Injuries
{
    public class PlayerInjured : PersonInfo
    {
        public PlayerInjured()
        {
        }
        public string? type { get; set; }
        public string? reason { get; set; }
    }
}
