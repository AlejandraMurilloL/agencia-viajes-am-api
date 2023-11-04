using AgenciaViajes.Application.Repositories;
using AgenciaViajes.Domain.Entities;
using AgenciaViajes.Infrastructure.Repositories;
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

            // Repositories
            services.AddScoped<IRepository<UserType>, MongoRepository<UserType>>();
            services.AddScoped<IRepository<Hotel>, MongoRepository<Hotel>>();
            services.AddScoped<IRepository<RoomType>, MongoRepository<RoomType>>();

            return services;
        }
    }
}
