using api_football.Models;
using api_football.Models.Odds.Live;
using api_football.Models.Odds.PreGame;
using api_football.Models.Odds.PreGame.Mapping;
using api_football.Models.Root;

namespace api_football.Handlers.Interfaces
{
    public interface IOddHandler
    {
        Task<RootCallResult<LiveOdd[]>> GetLiveOdds(int? fixture, int? league, int? bet);
        Task<RootCallResult<IdNameTuple[]>> GetAvailableLiveBets(string? id, string? search);
        Task<RootCallResult<PregameOdds[]>> GetPreGameOdds(int? fixture, int? league, int? season, string? date, string? timezone, int? page, int? bookmaker, int? bet);
        Task<RootCallResult<Mapping[]>> GetMappings(int? page);
        Task<RootCallResult<IdNameTuple[]>> GetAvailablePreGameBets(string? id, string? search);
        Task<RootCallResult<IdNameTuple[]>> GetAvailableBookMakers(string? id, string? search);
    }
}
