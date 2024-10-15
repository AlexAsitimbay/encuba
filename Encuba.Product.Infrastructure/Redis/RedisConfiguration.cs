using Microsoft.Extensions.Configuration;
using StackExchange.Redis;

namespace Encuba.Product.Infrastructure.Redis;

public class RedisConfiguration
{
    private readonly IConfiguration _configuration;
    public ConnectionMultiplexer Connection { get; }

    public RedisConfiguration(IConfiguration configuration)
    {
        _configuration = configuration;

        var connectionString = _configuration["Redis:ConnectionString"];
        var user = _configuration["Redis:User"];
        var password = _configuration["Redis:Password"];
        
        var options = ConfigurationOptions.Parse(connectionString);
        options.User = user;
        options.Password = password;
        
        Connection = ConnectionMultiplexer.Connect(options);
    }
}