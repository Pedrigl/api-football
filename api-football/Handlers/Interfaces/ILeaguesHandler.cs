﻿using api_football.Models.League;
using api_football.Models.Root;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Handlers.Interfaces
{
    public interface ILeaguesHandler
    {
        Task<RootCallResult<League[]>> GetLeagues();
        Task<RootCallResult<int[]>> GetSeasons();
    }
}
