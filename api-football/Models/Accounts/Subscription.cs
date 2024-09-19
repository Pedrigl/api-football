namespace api_football.Models.Accounts
{
    public class Subscription
    {
        public Subscription() { }
        public required string plan { get; set; }
        public DateTime end { get; set; }
        public bool active { get; set; }
    }
}
