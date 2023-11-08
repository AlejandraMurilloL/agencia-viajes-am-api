using AgenciaViajes.Domain.Entities;
using AutoMapper;

namespace AgenciaViajes.Application.Features.ReservationFeatures.Command.CreateReservation
{
    public class CreateReservationMapper : Profile
    {
        public CreateReservationMapper()
        {
            CreateMap<CreateReservationGuest, Guest>()
                .ForMember(x => x.Phone, x => x.MapFrom(src => src.ContactPhone));
        }
    }
}
