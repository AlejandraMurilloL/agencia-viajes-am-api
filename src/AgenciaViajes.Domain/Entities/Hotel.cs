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
        }
    }
}
