using MongoDB.Bson;

namespace AgenciaViajes.Application.Features.HotelFeatures.Queries.GetHotelsByUser
{
    public class GetHotelsByUserResponse 
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string City { get; set; } = null!;
        public bool Active { get; set; }
        public List<HotelRoom> Rooms { get; set; }

        public GetHotelsByUserResponse()
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
        public string RoomType { get; set; } = null!;
        public string RoomTypeId { get; set; } = null!;
        public string Location { get; set; } = null!;
        public bool Active { get; set; }
    }
}
