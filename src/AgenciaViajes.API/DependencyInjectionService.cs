namespace AgenciaViajes.API
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddWebApi(this IServiceCollection services)
        {
            services.AddCors(opt =>
            {
                opt.AddDefaultPolicy(builder => builder
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });

            return services;
        }
    }
}
