namespace AgenciaViajes.Application.Features.ReservationFeatures.Command.CreateReservation
{
    public class CreateReservationRequest
    {
        public int HotelId { get; set; }
        public int RoomId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ContactName { get; set; } = null!;
        public string ContactPhone { get; set; } = null!;
        public List<CreateReservationGuest> Guests { get; set; } = new List<CreateReservationGuest>();
    }

    public class CreateReservationGuest
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime Birthday { get; set; }
        public string Gender { get; set; } = null!;
        public string DocumentType { get; set; } = null!;
        public string DocumentNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
    }
}
