namespace api_football.Models.Odds.PreGame
{
    public class PreGameBet : IdNameTuple
    {
        public PreGameBet()
        {
        }
        public required ValueOddTuple[] values { get; set; }
    }
}
