using System.Collections;
using System.Collections.Generic;

namespace CharacterGen.Domain.Background
{
    public interface IBackground
    {
        void UpdateName(string name);
        void UpdateFeature(string feature);
        void UpdateAlternateFeature(string feature);

        void UpdateSuggestedTraits(IEnumerable<string> traits);
        void UpdateSuggestedIdeals(IEnumerable<string> ideals);
        void UpdateSuggestedBonds(IEnumerable<string> bonds);
        void UpdateSuggestedFlaws(IEnumerable<string> flaws);

    }
}