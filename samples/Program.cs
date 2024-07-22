using api_football.Extensions;
using api_football.Extensions.Http;
using api_football.Handlers.Interfaces;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddApiFootballServices(new ApiSportsClientBuilder("20fbdf493eb459564d090a9583f4085a"));

var serviceProvider = services.BuildServiceProvider();

var coachesHandler = serviceProvider.GetRequiredService<ICoachesHandler>();

var coaches = await coachesHandler.GetCoaches(null,null,null);

foreach (var coach in coaches.response)
{
    Console.WriteLine(coach.firstname);
}

