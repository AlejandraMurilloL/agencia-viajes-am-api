using AgenciaViajes.Domain.Common;
using MongoDB.Bson;

namespace AgenciaViajes.Domain.Entities
{
    public class Hotel : IDocument
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string City { get; set; } = null!;
        public bool Active { get; set; }
        public List<Room> Rooms { get; set; }

        public Hotel()
        {
            Rooms = new List<Room>();
            Active = true;
        }

        public Hotel WithName(string name)
        {
            Name = name;
            return this;
        }
        public Hotel WithDescription(string description)
        {
            Description = description;
            return this;
        }

        public Hotel WithCity(string city)
        {
            City = city;
            return this;
        }

        public Hotel WithState(bool active)
        {
            Active = active;
            return this;
        }

        public Hotel AddRoom(Room room)
        {
            Rooms.Add(room);
            return this;
        }
    }
}
