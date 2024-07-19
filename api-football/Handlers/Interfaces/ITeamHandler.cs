using api_football.Models.Root;
using api_football.Models.Statistics;
using api_football.Models.Teams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Handlers.Interfaces
{
    public interface ITeamHandler
    {
        Task<RootCallResult<Team[]>> GetTeamsInformations(int? id, string name, int? league, int? season, string? country, string? code, int? venue, string? search);
        Task<RootCallResult<TeamStatistics>> 
    }
}
