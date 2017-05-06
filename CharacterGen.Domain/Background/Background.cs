using System.Collections.Generic;
using System.Runtime.Serialization;
using MongoDB.Bson;

namespace CharacterGen.Domain.Background
{
    public class Background : IBackground
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Feature { get; set; }
        public string AlternateFeature { get; set; }

        public IEnumerable<string> SuggestedTraits { get; set; }
        public IEnumerable<string> SuggestedIdeals { get; set; }
        public IEnumerable<string> SuggestedBonds { get; set; }
        public IEnumerable<string> SuggestedFlaws { get; set; }

        public void UpdateName(string name)
        {
            this.Name = name;
        }

        public void UpdateFeature(string feature)
        {
            this.Feature = feature;
        }

        public void UpdateAlternateFeature(string feature)
        {
            this.AlternateFeature = feature;
        }

        public void UpdateSuggestedTraits(IEnumerable<string> traits)
        {
            this.SuggestedTraits = traits;
        }

        public void UpdateSuggestedIdeals(IEnumerable<string> ideals)
        {
            this.SuggestedIdeals = ideals;
        }

        public void UpdateSuggestedBonds(IEnumerable<string> bonds)
        {
            this.SuggestedBonds = bonds;
        }

        public void UpdateSuggestedFlaws(IEnumerable<string> flaws)
        {
            this.SuggestedFlaws = flaws;
        }
    }
}