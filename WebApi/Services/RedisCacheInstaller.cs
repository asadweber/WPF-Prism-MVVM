using AspNetCore.CacheOutput.Redis.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi.Services
{
    /// <summary>
    /// RedisCacheInstaller
    /// </summary>
    public class RedisCacheInstaller : IInstaller
    {
        /// <summary>
        /// InstallServices
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            //var redisConnectionStrings = configuration.GetSection(nameof(RedisConnectionStrings)).Get<RedisConnectionStrings>();


            //var redisConfigurationOptions = ConfigurationOptions.Parse("localhost:6379");

            //services.AddStackExchangeRedisCache(redisCacheConfig =>
            //{
            //    redisCacheConfig.ConfigurationOptions = redisConfigurationOptions;
            //});

            //services.AddStackExchangeRedisCache(redisCacheConfig =>
            //{
            //    redisCacheConfig.ConfigurationOptions = redisConnectionStrings.RedisCache;
            //});


            //services.AddStackExchangeRedisCache(options =>
            //{
            //    options.Configuration = _config["MyRedisConStr"];
            //    options.InstanceName = "SampleInstance";
            //});

            //var conStr = configuration["RedisConnectionStrings:RedisCache"];
            //services.AddRedisCacheOutput(conStr);
        }
    }
}
