using AgenciaViajes.Application.Features.ReservationFeatures.Queries.GetReservations;

namespace AgenciaViajes.Application.Features.ReservationFeatures.Queries.GetAvailableRooms
{
    public interface IGetAvailableRoomsQuery
    {
        Task<List<GetAvailableRoomsResponse>> Execute(GetAvailableRoomsRequest filter);
    }
}
