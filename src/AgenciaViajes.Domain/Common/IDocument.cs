using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AgenciaViajes.Domain.Common
{
    public interface IDocument
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public ObjectId Id { get; set; }
    }
}
