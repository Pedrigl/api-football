using api_football.Extensions;
using api_football.Extensions.Http;
using api_football.Handlers.Fixtures;
using api_football.Handlers.Interfaces;
using api_football.Models;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddApiFootballServices(new ApiSportsClientBuilder(""));

var serviceProvider = services.BuildServiceProvider();

var fixturesHandler = serviceProvider.GetRequiredService<IFixturesHandler>();

var fixture = await fixturesHandler.GetFixtures(new FixtureQueryParameters
{
    Team = 6,
    League = 1,
    Season = 2018
    
});

Console.WriteLine(fixture.response.Length);


