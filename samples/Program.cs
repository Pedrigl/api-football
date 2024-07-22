using api_football.Extensions;
using api_football.Extensions.Http;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddApiFootballServices(new ApiSportsClientBuilder("20fbdf493eb459564d090a9583f4085a", services.))