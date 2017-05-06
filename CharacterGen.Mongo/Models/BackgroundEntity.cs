using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CharacterGen.Mongo.Models
{
    public class BackgroundEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Feature { get; set; }
        public string AlternateFeature { get; set; }

        public IEnumerable<string> SuggestedTraits { get; set; }
        public IEnumerable<string> SuggestedIdeals { get; set; }
        public IEnumerable<string> SuggestedBonds { get; set; }
        public IEnumerable<string> SuggestedFlaws { get; set; }
    }
}