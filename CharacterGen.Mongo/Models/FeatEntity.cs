using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CharacterGen.Mongo.Models
{
    public class FeatEntity : IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<string> Benefits { get; set; }

        //TODO: How to handle feat requirements
        //public IEnumerable<Prerequisite> Prerequisites
        //TODO: How to handle feat bonuses
        //public IEnumerable<FeatBonus> FeatBonuses
    }
}