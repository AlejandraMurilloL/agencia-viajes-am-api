﻿using AgenciaViajes.Application.Features.HotelFeatures.Commands.CreateHotel;
using AgenciaViajes.Application.Features.HotelFeatures.Queries.GetHotelsByUser;
using AgenciaViajes.Application.Features.UserTypeFeatures.Queries.GetUserTypes;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AgenciaViajes.Application
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            services.AddScoped<IGetUserTypesQuery, GetUserTypesQuery>();

            // Hotels
            services.AddScoped<IGetHotelsByUserQuery, GetHotelsByUserQuery>();
            services.AddScoped<ICreateHotelCommand, CreateHotelCommand>();

            return services;
        }
    }
}
