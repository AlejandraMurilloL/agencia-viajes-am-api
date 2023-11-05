using AgenciaViajes.Application.Repositories;

namespace AgenciaViajes.Application
{
    public interface IUnitOfWork : IDisposable
    {
        IHotelRepository HotelRepository { get; set; }
        IRoomTypeRepository RoomTypeRepository { get; set; }
        IReservationRepository ReservationRepository { get; set; }
        IRoomRepository RoomRepository { get; set; }
        Task<int> SaveAsync();
    }
}
