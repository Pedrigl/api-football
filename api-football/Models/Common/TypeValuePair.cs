namespace api_football.Models.Common
{
    public class TypeValuePair<T>
    {
        public TypeValuePair()
        {
        }
        public required string type { get; set; }
        public required T value { get; set; }
    }
}
