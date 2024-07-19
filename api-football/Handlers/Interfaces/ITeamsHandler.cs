﻿using api_football.Models;
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
    public interface ITeamsHandler
    {
        Task<RootCallResult<Models.Teams.Team[]>> GetTeamsInformations(int? id, string? name, int? league, int? season, string? country, string? code, int? venue, string? search);
        Task<RootCallResult<TeamStatistics>> GetTeamStatistics(int league, int season, int team, string date);
        Task<RootCallResult<int[]>> GetTeamSeasons(int team);
        Task<RootCallResult<Country[]>> GetTeamsCountries();
    }
}