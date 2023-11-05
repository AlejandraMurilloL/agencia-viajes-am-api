namespace AgenciaViajes.Application.Features.ReservationFeatures.Queries.GetAvailableRooms
{
    public class GetAvailableRoomsResponse
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int HotelId { get; set; }
        public string HotelName { get; set; } = null!;
        public int RoomId { get; set; }
        public string RoomName { get; set; } = null!;
    }
}
