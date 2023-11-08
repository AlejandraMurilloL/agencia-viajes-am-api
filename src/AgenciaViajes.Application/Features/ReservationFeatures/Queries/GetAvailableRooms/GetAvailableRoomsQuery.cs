using AgenciaViajes.Application.Features.ReservationFeatures.Queries.GetReservations;
using AutoMapper;

namespace AgenciaViajes.Application.Features.ReservationFeatures.Queries.GetAvailableRooms
{
    public class GetAvailableRoomsQuery : IGetAvailableRoomsQuery
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAvailableRoomsQuery(
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<GetAvailableRoomsResponse>> Execute(GetAvailableRoomsRequest filter)
        {
            var rooms = await _unitOfWork.RoomRepository.GetAllAsync();

            var availableRooms = rooms.Where(x => x.RoomType.PeopleCapacity == filter.PeopleCount &&
                                                  x.Hotel.City.Contains(filter.City) &&
                                                  x.Hotel.Active && x.Active &&
                                                  (!x.Reservations.Any() || 
                                                   !x.Reservations.Any(x => filter.StartDate >= x.StartDate && x.StartDate <= filter.EndDate ||
                                                                            filter.StartDate >= x.EndDate && x.EndDate <= filter.EndDate)));  

            
            
            if (availableRooms == null)
                return new List<GetAvailableRoomsResponse>();

            var result = _mapper.Map<List<GetAvailableRoomsResponse>>(availableRooms);

            foreach (var item in result)
            {
                item.StartDate = filter.StartDate;
                item.EndDate = filter.EndDate;
            }

            return result;
        }
    }
}
