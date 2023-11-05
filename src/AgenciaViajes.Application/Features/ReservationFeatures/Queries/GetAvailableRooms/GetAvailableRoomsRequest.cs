namespace AgenciaViajes.Application.Features.ReservationFeatures.Queries.GetAvailableRooms
{
    public class GetAvailableRoomsRequest
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string City { get; set; } = null!;
        public int PeopleCount { get; set; }
    }
}
