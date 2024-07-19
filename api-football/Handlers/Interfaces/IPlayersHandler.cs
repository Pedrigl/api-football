using api_football.Models.Players;
using api_football.Models.Players.Squads;
using api_football.Models.Root;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Handlers.Interfaces
{
    public interface IPlayersHandler
    {
        Task<RootCallResult<int[]>> GetPlayersSeasons(int? id);
        Task<RootCallResult<Player[]>> GetPlayers(int? id, int? team, int? league, int? season, string? search, int? page);
        Task<RootCallResult<Squad[]>> GetSquads(int? id, int? team);
        Task<RootCallResult<TopStater[]>> GetTopScorers(int league, int season);
        Task<RootCallResult<TopStater[]>> GetTopAssisters(int league, int season);
        Task<RootCallResult<TopStater[]>> GetTopYellowCardReceivers(int league, int season);
        Task<RootCallResult<TopStater[]>> GetTopRedCardReceivers(int league, int season);
    }
}
