namespace api_football.Models.Common
{
    public class GenericHomeAway<T>
    {
        public GenericHomeAway()
        {
        }
        public required T home { get; set; }
        public required T away { get; set; }
    }
}
