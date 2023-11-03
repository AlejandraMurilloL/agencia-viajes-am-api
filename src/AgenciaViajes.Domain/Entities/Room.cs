using AgenciaViajes.Domain.Common;
using MongoDB.Bson;

namespace AgenciaViajes.Domain.Entities
{
    public class Room
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public ObjectId HotelId { get; set; }
        public double BaseCost { get; set; }
        public double Taxes { get; set; }
        public ObjectId RoomTypeId { get; set; }
        public string Location { get; set; } = null!;
        public bool Active { get; set; }

    }
}
