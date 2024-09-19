namespace api_football.Models.Common
{
    public class GenericHomeAwayTotal<T> : GenericHomeAway<T>
    {
        public GenericHomeAwayTotal()
        {
        }
        public required T total { get; set; }
    }
}
