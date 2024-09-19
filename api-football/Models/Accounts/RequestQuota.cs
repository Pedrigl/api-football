namespace api_football.Models.Accounts
{
    public class RequestQuota
    {
        public RequestQuota() { }
        public int current { get; set; }
        public int limit_day { get; set; }
    }
}
