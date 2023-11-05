namespace AgenciaViajes.Application.Features.ReservationFeatures.Queries.GetReservations
{
    public class GetReservationsResponse
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public string HotelName { get; set; } = null!;
        public int RoomId { get; set; }
        public string RoomName { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ContactName { get; set; } = null!;
        public string ContactPhone { get; set; } = null!;
        public List<GuestResponse> Guests { get; set; } = new List<GuestResponse>();
    }

    public class GuestResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime Birthday { get; set; }
        public string Gender { get; set; } = null!;
        public string DocumentType { get; set; } = null!;
        public string DocumentNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string ContactPhone { get; set; } = null!;

    }
}
