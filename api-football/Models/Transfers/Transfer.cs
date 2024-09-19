namespace api_football.Models.Transfers
{
    public class Transfer
    {
        public required IdNameTuple player { get; set; }
        public DateTime update { get; set; }
        public required TransferInfo[] transfers { get; set; }
    }
}
