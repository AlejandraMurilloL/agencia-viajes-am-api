using AgenciaViajes.Application.Features.HotelFeatures.Commands.CreateHotel;
using AgenciaViajes.Application.Features.HotelFeatures.Commands.CreateHotelRoom;
using AgenciaViajes.Application.Features.HotelFeatures.Commands.UpdateHotel;
using AgenciaViajes.Application.Features.HotelFeatures.Commands.UpdateHotelRoom;
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
            services.AddScoped<IUpdateHotelCommand, UpdateHotelCommand>();
            services.AddScoped<ICreateHotelRoomCommand, CreateHotelRoomCommand>();
            services.AddScoped<IUpdateHotelRoomCommand, UpdateHotelRoomCommand>();

            return services;
        }
    }
}
