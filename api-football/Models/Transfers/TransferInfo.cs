namespace api_football.Models.Transfers
{
    public class TransferInfo
    {
        public TransferInfo()
        {
        }
        public required string date { get; set; }
        public required string type { get; set; }
        public required TransferTeams teams { get; set; }
    }
}
