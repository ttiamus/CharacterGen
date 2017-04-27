using System.Collections;
using System.Collections.Generic;
using CharacterGen.Domain.AbilityScore;
using CharacterGen.Domain.Enumerations;
using CharacterGen.Domain.Languages;

namespace CharacterGen.Domain.Race
{
    public interface IRace
    {
        void UpdateName(string name);
        void UpdateSubraceName(string subraceName);
        void UpdateSubraceDescription(string subraceDescription);
        void UpdateAbilityScoreIncreases(AbilityScores abilityScores);
        void UpdateAverageAge(int averageAge);
        void UpdateSuggestedAlignment(string alignmentValue);
        void UpdateSuggestedAlignment(Alignment alignment);
        void UpdateSpeed(int speed);
        void UpdateLanguages(IEnumerable<Language> languages);
        void UpdateRacialAbilities(IEnumerable<string> racialAbilities);
    }
}