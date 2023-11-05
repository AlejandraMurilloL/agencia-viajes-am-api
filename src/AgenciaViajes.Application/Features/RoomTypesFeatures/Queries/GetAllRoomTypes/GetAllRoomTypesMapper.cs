using AgenciaViajes.Domain.Entities;
using AutoMapper;

namespace AgenciaViajes.Application.Features.RoomTypes.Queries.GetAllRoomTypes
{
    public class GetAllRoomTypesMapper : Profile
    {
        public GetAllRoomTypesMapper()
        {
            CreateMap<RoomType, GetAllRoomTypesResponse>();
        }
    }
}
