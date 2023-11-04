using AgenciaViajes.Domain.Common;
using MongoDB.Bson;

namespace AgenciaViajes.Domain.Entities
{
    public class UserType 
    {
        public ObjectId Id { get; set; }
        public string Type { get; set; } = null!;
    }
}
