namespace api_football.Models.Players
{
    public class Player
    {
        public required PlayerInfo player { get; set; }
        public required PlayerStatistics statistics { get; set; }
    }
}
