﻿using AgenciaViajes.Application.Features.UserTypeFeatures.Queries.GetUserTypes;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AgenciaViajes.Application
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped<IGetUserTypesQuery, GetUserTypesQuery>();

            return services;
        }
    }
}
