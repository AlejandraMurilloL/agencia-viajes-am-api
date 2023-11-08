namespace AgenciaViajes.Application.Features.HotelFeatures.Queries.GetHotelById
{
    public class GetHotelByIdResponse
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string City { get; set; } = null!;
        public bool Active { get; set; }
        public List<HotelRoom> Rooms { get; set; }

        public GetHotelByIdResponse()
        {
            Rooms = new List<HotelRoom>();
        }

    }

    public class HotelRoom
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string HotelId { get; set; } = null!;
        public double BaseCost { get; set; }
        public double Taxes { get; set; }
        public string RoomTypeName { get; set; } = null!;
        public string RoomTypeId { get; set; } = null!;
        public string Location { get; set; } = null!;
        public bool Active { get; set; }
    }
}
