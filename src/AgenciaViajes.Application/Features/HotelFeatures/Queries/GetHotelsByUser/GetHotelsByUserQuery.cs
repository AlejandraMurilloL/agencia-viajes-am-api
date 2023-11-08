using AutoMapper;

namespace AgenciaViajes.Application.Features.HotelFeatures.Queries.GetHotelsByUser
{
    public class GetHotelsByUserQuery : IGetHotelsByUserQuery
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetHotelsByUserQuery(
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<GetHotelsByUserResponse>> Execute()
        {
            var hotels = await _unitOfWork.HotelRepository.GetAllAsync();

            if (hotels == null)
                return new List<GetHotelsByUserResponse>();

            return _mapper.Map<List<GetHotelsByUserResponse>>(hotels);
        }
    }
}
  