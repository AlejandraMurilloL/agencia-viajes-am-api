using AgenciaViajes.Domain.Common;
using MongoDB.Bson;

namespace AgenciaViajes.Domain.Entities
{
    public class Reservation : IDocument
    {
        public ObjectId Id { get; set; }
        public ObjectId HotelId { get; set; }
        public ObjectId RoomId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ContactName { get; set; } = null!;
        public string ContactPhone { get; set; } = null!;
       
    }
}
