using api_football.Handlers.Odds;
using api_football.Models;
using api_football.Models.Common;
using api_football.Models.Odds.Live;
using api_football.Models.Odds.PreGame;
using api_football.Models.Odds.PreGame.Mapping;
using api_football.Models.Root;

namespace api_football.Handlers.Interfaces
{
    public interface IOddHandler
    {
        Task<RootCallResult<LiveOdd[]>> GetLiveOdds(LiveOddQueryParameters parameters);
        Task<RootCallResult<IdNameTuple[]>> GetAvailableLiveBets(AvailableBetQueryParameters parameters);
        Task<RootCallResult<PregameOdds[]>> GetPreGameOdds(PreGameOddQueryParameters parameters);
        Task<RootCallResult<Mapping[]>> GetMappings(MappingQueryParameters parameters);
        Task<RootCallResult<IdNameTuple[]>> GetAvailablePreGameBets(AvailableBetQueryParameters parameters);
    }
}