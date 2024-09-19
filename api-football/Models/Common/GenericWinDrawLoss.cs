namespace api_football.Models.Common
{
    public class GenericWinDrawLoss<T>
    {
        public GenericWinDrawLoss()
        {
        }
        public required T wins { get; set; }
        public required T draws { get; set; }
        public required T loses { get; set; }
    }
}
