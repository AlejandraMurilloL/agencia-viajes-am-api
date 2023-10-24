using AgenciaViajes.Infrastructure.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AgenciaViajes.Infrastructure
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<MongoDBSettings>(configuration.GetSection("MongoDbSettings"));
            return services;
        }
    }
}
