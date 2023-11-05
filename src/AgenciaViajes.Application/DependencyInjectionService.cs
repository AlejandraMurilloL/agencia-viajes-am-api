using AgenciaViajes.Application.Features.HotelFeatures.Commands.CreateHotel;
using AgenciaViajes.Application.Features.HotelFeatures.Commands.CreateHotelRoom;
using AgenciaViajes.Application.Features.HotelFeatures.Commands.UpdateHotel;
using AgenciaViajes.Application.Features.HotelFeatures.Commands.UpdateHotelRoom;
using AgenciaViajes.Application.Features.HotelFeatures.Commands.UpdateHotelRoomStatus;
using AgenciaViajes.Application.Features.HotelFeatures.Commands.UpdateHotelStatus;
using AgenciaViajes.Application.Features.HotelFeatures.Queries.GetHotelsByUser;
using AgenciaViajes.Application.Features.ReservationFeatures.Queries.GetReservations;
using AgenciaViajes.Application.Features.RoomTypes.Queries.GetAllRoomTypes;
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

            // Hotels
            services.AddScoped<IGetHotelsByUserQuery, GetHotelsByUserQuery>();
            services.AddScoped<ICreateHotelCommand, CreateHotelCommand>();
            services.AddScoped<IUpdateHotelCommand, UpdateHotelCommand>();
            services.AddScoped<IUpdateHotelStatusCommand, UpdateHotelStatusCommand>();
            services.AddScoped<ICreateHotelRoomCommand, CreateHotelRoomCommand>();
            services.AddScoped<IUpdateHotelRoomCommand, UpdateHotelRoomCommand>();
            services.AddScoped<IUpdateHotelRoomStatusCommand, UpdateHotelRoomStatusCommand>();

            // Room Types
            services.AddScoped<IGetAllRoomTypesQuery, GetAllRoomTypesQuery>();

            // Reservations
            services.AddScoped<IGetReservationsQuery, GetReservationsQuery>();

            return services;
        }
    }
}
