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

        public Room(string hotelId)
        {
            Id =  Guid.NewGuid().ToString();
            HotelId = ObjectId.Parse(hotelId);
            Active = true;
        }

        public Room WithName(string name)
        {
            Name = name;
            return this;
        }

        public Room WithBaseCost(double baseCost)
        {
            BaseCost = baseCost;
            return this;
        }

        public Room WithTaxes(double taxes)
        {
            Taxes = taxes;
            return this;
        }

        public Room WithRoomTypeId(string roomTypeId)
        {
            RoomTypeId = ObjectId.Parse(roomTypeId);
            return this;
        }

        public Room WithLocation(string location)
        {
            Location = location;
            return this;
        }

    }
}
