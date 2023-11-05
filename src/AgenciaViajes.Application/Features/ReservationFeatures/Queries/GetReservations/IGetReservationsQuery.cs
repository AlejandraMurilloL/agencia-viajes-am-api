using AgenciaViajes.Application.Features.RoomTypes.Queries.GetAllRoomTypes;

namespace AgenciaViajes.Application.Features.ReservationFeatures.Queries.GetReservations
{
    public interface IGetReservationsQuery
    {
        Task<List<GetReservationsResponse>> Execute();
    }
}
