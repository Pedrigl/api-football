using api_football.Models.Fixtures;
using api_football.Models.Fixtures.Lineups;
using api_football.Models.Fixtures.PlayersStatistics;
using api_football.Models.Root;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Handlers.Interfaces
{
    public interface IFixturesHandler
    {
        Task<RootCallResult<string[]>> GetRounds(int league, int season, bool? current);
        Task<RootCallResult<Fixture[]>> GetFixtures(int? id, string? ids, string? live, string? date, int? league, int? season, int? team, int? last, int? next, string? from, string? to, string? round, string? status, int? venue, string? timezone);
        Task<RootCallResult<Fixture[]>> GetH2HFixtures(string h2h, string? date, int? league, int? season, int? last, int? next, string? from, string? to, string? status, int? venue, string? timezone);
        Task<RootCallResult<FixtureStats[]>> GetFixtureStatistics(int fixture, int? team, string? type);
        Task<RootCallResult<FixtureEvent[]>> GetFixtureEvents(int fixture, int? team, string? player, string? type);
        Task<RootCallResult<Lineup[]>> GetFixtureLineups(int fixture, int? team, int? player, string? type);
        Task<RootCallResult<PlayerStats[]>> GetFixturePlayersStats(int fixture, int? team);
    }
}
