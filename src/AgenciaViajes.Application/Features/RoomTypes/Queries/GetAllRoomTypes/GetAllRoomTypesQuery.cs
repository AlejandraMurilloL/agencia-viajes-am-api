using AgenciaViajes.Application.Repositories;
using AgenciaViajes.Domain.Entities;
using AutoMapper;

namespace AgenciaViajes.Application.Features.RoomTypes.Queries.GetAllRoomTypes
{
    public class GetAllRoomTypesQuery : IGetAllRoomTypesQuery
    {
        private readonly IRepository<RoomType> _roomTypeRepository;
        private readonly IMapper _mapper;

        public GetAllRoomTypesQuery(
            IRepository<RoomType> roomTypeRepository,
            IMapper mapper)
        {
            _roomTypeRepository = roomTypeRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllRoomTypesResponse>> Execute()
        {
            var roomTypes = _roomTypeRepository.AsQueryable();

            if (roomTypes == null)
                return new List<GetAllRoomTypesResponse>();

            return _mapper.Map<List<GetAllRoomTypesResponse>>(roomTypes);
        }
    }
}
