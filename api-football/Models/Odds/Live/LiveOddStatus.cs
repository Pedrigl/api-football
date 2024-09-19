namespace api_football.Models.Odds.Live
{
    public class LiveOddStatus
    {
        public LiveOddStatus()
        {
        }
        public bool? stopped { get; set; }
        public bool? blocked { get; set; }
        public bool? finished { get; set; }
    }
}
