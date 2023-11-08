using AgenciaViajes.Domain.Entities;
using AutoMapper;

namespace AgenciaViajes.Application.Features.HotelFeatures.Queries.GetHotelById
{
    public  class GetHotelByIdMapper : Profile
    {
        public GetHotelByIdMapper()
        {
            CreateMap<Hotel, GetHotelByIdResponse>();
            CreateMap<Room, HotelRoom>();
        }
    }
}
