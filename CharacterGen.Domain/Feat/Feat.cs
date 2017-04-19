using System.Collections;
using System.Collections.Generic;
using MongoDB.Bson;

namespace CharacterGen.Domain.Feat
{
    public class Feat : IFeat
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<string> Benefits { get; set; }

        //TODO: How to handle feat requirements
        //public IEnumerable<Prerequisite> Prerequisites
        //TODO: How to handle feat bonuses
        //public IEnumerable<FeatBonus> FeatBonuses

        public void UpdateName(string name)
        {
            this.Name = name;
        }

        public void UpdateDescription(string description)
        {
            this.Description = description;
        }

        public void UpdateBenefits(IEnumerable<string> benefits)
        {
            this.Benefits = benefits;
        }
    }
}