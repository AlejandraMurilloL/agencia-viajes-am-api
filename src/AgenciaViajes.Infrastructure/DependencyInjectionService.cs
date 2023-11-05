using AgenciaViajes.Application;
using AgenciaViajes.Application.Repositories;
using AgenciaViajes.Infrastructure.Database;
using AgenciaViajes.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AgenciaViajes.Infrastructure
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AgenciaViajesContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("AgenciaViajesDatabase"));
            });

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            // Repositories
            services.AddScoped<IHotelRepository, HotelRepository>();
            services.AddScoped<IRoomTypeRepository, RoomTypeRepository>();
            services.AddScoped<IReservationRepository, ReservationRepository>();
            services.AddScoped<IRoomRepository, RoomRepository>();

            return services;
        }
    }
}
