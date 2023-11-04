using AgenciaViajes.Application;
using AgenciaViajes.Application.Repositories;
using AgenciaViajes.Infrastructure.Database;

namespace AgenciaViajes.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        public IHotelRepository HotelRepository { get; set; }
        public IRoomTypeRepository RoomTypeRepository { get; set; }
        public IReservationRepository ReservationRepository { get; set; }

        private readonly AgenciaViajesContext _agenciaViajesContext;

        public UnitOfWork(AgenciaViajesContext agenciaViajesContext,
                          IHotelRepository hotelRepository,
                          IRoomTypeRepository roomTypeRepository,
                          IReservationRepository reservationRepository
                          )
        {
            _agenciaViajesContext = agenciaViajesContext;
            HotelRepository = hotelRepository;
            RoomTypeRepository = roomTypeRepository;
            ReservationRepository = reservationRepository;
        }

        public async Task<int> SaveAsync() => await _agenciaViajesContext.SaveChangesAsync();

        public void Dispose() => _agenciaViajesContext.Dispose();
    }
}
