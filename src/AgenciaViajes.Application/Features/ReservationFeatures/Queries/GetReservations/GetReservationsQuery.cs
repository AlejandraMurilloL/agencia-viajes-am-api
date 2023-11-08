using AgenciaViajes.Application.Features.RoomTypes.Queries.GetAllRoomTypes;
using AutoMapper;

namespace AgenciaViajes.Application.Features.ReservationFeatures.Queries.GetReservations
{
    public class GetReservationsQuery : IGetReservationsQuery
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetReservationsQuery(
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<GetReservationsResponse>> Execute()
        {
            var reservations = await _unitOfWork.ReservationRepository.GetAllAsync();

            if (reservations == null)
                return new List<GetReservationsResponse>();

            return _mapper.Map<List<GetReservationsResponse>>(reservations);
        }
    }
}
