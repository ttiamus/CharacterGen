using System.Collections.Generic;
using CharacterGen.Domain.Enumerations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CharacterGen.Mongo.Models
{
    public class SpellEntity : IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; }
        public string Name { get; set; }
        public int Level { get; set; }
        public SpellSchool School { get; set; }
        public string Description { get; set; }
        public IEnumerable<SpellComponent> Components { get; set; }
        public Action CastingTime { get; set; }
        public bool IsRitual { get; set; }
        public string Range { get; set; }
        public int Cost { get; set; }
        public string Duration { get; set; }
    }
}