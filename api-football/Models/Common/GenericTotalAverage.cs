namespace api_football.Models.Common
{
    public class GenericTotalAverage<Tt, Ta>
    {
        public GenericTotalAverage()
        {
        }
        public required Tt total { get; set; }
        public required Ta average { get; set; }
    }
}
