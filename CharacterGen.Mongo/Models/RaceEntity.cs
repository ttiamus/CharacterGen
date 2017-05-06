using System.Collections.Generic;
using CharacterGen.Domain.AbilityScore;
using CharacterGen.Domain.Enumerations;
using CharacterGen.Domain.Languages;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CharacterGen.Mongo.Models
{
    public class RaceEntity : IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string SubraceName { get; set; }
        public string SubraceDescription { get; set; }
        public AbilityScores AbilityScoreIncreases { get; set; }
        public int AverageAge { get; set; }
        public Alignment SuggestedAlignment { get; set; }
        public int Speed { get; set; } //in feet
        public IEnumerable<Language> Languages { get; set; }
        public IEnumerable<string> RacialAbilities { get; set; }

        //TODO: Find out how to handle dynamic abilities
        //public IEnumerable<RacialAbility> RacialAbilities { get; set; }
    }
}