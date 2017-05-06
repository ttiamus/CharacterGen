using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CharacterGen.Mongo.Models
{
    public class ArmorEntity : IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
    }
}