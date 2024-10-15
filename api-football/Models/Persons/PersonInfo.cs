using api_football.Models.Common;

namespace api_football.Models.Persons
{
    public class PersonInfo : IdNameTuple
    {
        public PersonInfo()
        {
        }
        public string? photo { get; set; }
    }
}
