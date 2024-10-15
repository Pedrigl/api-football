using api_football.Models.Common;

namespace api_football.Models.Odds.PreGame
{
    public class PregameBookmaker : IdNameTuple
    {
        public PregameBookmaker()
        {
        }
        public required PreGameBet[] bets { get; set; }
    }
}
