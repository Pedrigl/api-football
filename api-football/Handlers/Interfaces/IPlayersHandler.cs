using api_football.Handlers.Players;
using api_football.Models.Players;
using api_football.Models.Players.Squads;
using api_football.Models.Root;

namespace api_football.Handlers.Interfaces
{
    public interface IPlayersHandler
    {
        Task<RootCallResult<int[]>> GetPlayersSeasons(int? id);
        Task<RootCallResult<Player[]>> GetPlayers(PlayerQueryParameters parameters);
        Task<RootCallResult<Squad[]>> GetSquads(SquadQueryParameters parameters);
        Task<RootCallResult<TopStater[]>> GetTopScorers(TopStatQueryParameters parameters);
        Task<RootCallResult<TopStater[]>> GetTopAssisters(TopStatQueryParameters parameters);
        Task<RootCallResult<TopStater[]>> GetTopYellowCardReceivers(TopStatQueryParameters parameters);
        Task<RootCallResult<TopStater[]>> GetTopRedCardReceivers(TopStatQueryParameters parameters);
    }
}