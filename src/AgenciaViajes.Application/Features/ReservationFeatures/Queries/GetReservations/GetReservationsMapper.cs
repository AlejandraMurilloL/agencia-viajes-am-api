using AgenciaViajes.Domain.Entities;
using AutoMapper;

namespace AgenciaViajes.Application.Features.ReservationFeatures.Queries.GetReservations
{
    public class GetReservationsMapper : Profile
    {
        public GetReservationsMapper() 
        {
            CreateMap<Reservation, GetReservationsResponse>();
            CreateMap<Guest, GuestResponse>();
        }
    }
}
