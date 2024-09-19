namespace api_football.Models.Statistics
{
    public class FormationPlayed
    {
        public FormationPlayed()
        {
        }
        public required string formation { get; set; }
        public int played { get; set; }
    }
}
