namespace api_football.Models.Common
{
    public class GenericHomeDrawAway<T> : GenericHomeAway<T>
    {
        public GenericHomeDrawAway()
        {
        }
        public required T draw { get; set; }
    }
}
