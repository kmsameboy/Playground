using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SaverAPI.Data;
using SaverAPI.HealthChecks;

namespace SaverAPI.Installers
{
    public class HealthChecksInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddHealthChecks()
                .AddDbContextCheck<DataContext>()
                .AddCheck<RedisHealthCheck>("Redis");
        }
    }
}