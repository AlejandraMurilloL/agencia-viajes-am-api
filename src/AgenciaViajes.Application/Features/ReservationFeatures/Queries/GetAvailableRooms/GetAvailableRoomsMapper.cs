using AgenciaViajes.Domain.Entities;
using AutoMapper;

namespace AgenciaViajes.Application.Features.ReservationFeatures.Queries.GetAvailableRooms
{
    public class GetAvailableRoomsMapper : Profile
    {
        public GetAvailableRoomsMapper()
        {
            CreateMap<Room, GetAvailableRoomsResponse>()
                .ForMember(x => x.RoomId, x => x.MapFrom(src => src.Id))
                .ForMember(x => x.RoomName, x => x.MapFrom(src => src.Name))
                .ForMember(x => x.StartDate, opt => opt.Ignore())
                .ForMember(x => x.EndDate, opt => opt.Ignore());
        }
    }
}
