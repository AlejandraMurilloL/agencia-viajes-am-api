using AgenciaViajes.Domain.Common;
using MongoDB.Bson;

namespace AgenciaViajes.Domain.Entities
{
    public class RoomType: IDocument
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; } = null!;
        public int PeopleCapacity { get; set; }

    }
}
