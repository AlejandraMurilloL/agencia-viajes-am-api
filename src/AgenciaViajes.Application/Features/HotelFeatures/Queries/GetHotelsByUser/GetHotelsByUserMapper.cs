using AgenciaViajes.Domain.Entities;
using AutoMapper;

namespace AgenciaViajes.Application.Features.HotelFeatures.Queries.GetHotelsByUser
{
    public class GetHotelsByUserMapper : Profile
    {
        public GetHotelsByUserMapper()
        {
            CreateMap<Hotel, GetHotelsByUserResponse>();
            CreateMap<Room, HotelRoom>();
        }
    }
}
