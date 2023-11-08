using AutoMapper;

namespace AgenciaViajes.Application.Features.HotelFeatures.Queries.GetHotelById
{
    public class GetHotelByIdQuery : IGetHotelByIdQuery
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetHotelByIdQuery(
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<GetHotelByIdResponse> Execute(int id)
        {
            var hotel = await _unitOfWork.HotelRepository.GetByIdAsync(id);
            return _mapper.Map<GetHotelByIdResponse>(hotel);
        }
    }
}
