namespace api_football.Extensions.Http
{
    public interface IClientBuilder
    {
        HttpClient Build();
        void Configure(HttpClient client);
    }
}
