using api_football.Handlers.Fixtures;
using api_football.Models;
using api_football.Models.Fixtures;
using api_football.Models.Fixtures.Lineups;
using api_football.Models.Fixtures.PlayersStatistics;
using api_football.Models.Root;

namespace api_football.Handlers.Interfaces
{
    public interface IFixturesHandler
    {
        Task<RootCallResult<string[]>> GetRounds(int league, int season, bool? current);
        Task<RootCallResult<Fixture[]>> GetFixtures(FixtureQueryParameters parameters);
        Task<RootCallResult<Fixture[]>> GetH2HFixtures(H2HFixtureQueryParameters parameters);
        Task<RootCallResult<FixtureStats[]>> GetFixtureStatistics(FixtureQueryParams parameters);
        Task<RootCallResult<FixtureEvent[]>> GetFixtureEvents(FixtureEventQueryParams parameters);
        Task<RootCallResult<Lineup[]>> GetFixtureLineups(FixtureLineupQueryParams parameters);
        Task<RootCallResult<PlayerStats[]>> GetFixturePlayersStats(FixturePlayerStatsQueryParams parameters);
    }
}