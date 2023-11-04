using AutoMapper;

namespace AgenciaViajes.Application.Features.RoomTypes.Queries.GetAllRoomTypes
{
    public class GetAllRoomTypesQuery : IGetAllRoomTypesQuery
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllRoomTypesQuery(
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<GetAllRoomTypesResponse>> Execute()
        {
            var roomTypes = await _unitOfWork.RoomTypeRepository.GetAllAsync();

            if (roomTypes == null)
                return new List<GetAllRoomTypesResponse>();

            return _mapper.Map<List<GetAllRoomTypesResponse>>(roomTypes);
        }
    }
}
