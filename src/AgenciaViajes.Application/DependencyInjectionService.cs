using Microsoft.Extensions.DependencyInjection;

namespace AgenciaViajes.Application
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            return services;
        }
    }
}
