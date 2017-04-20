using System.Collections;
using System.Collections.Generic;
using CharacterGen.Domain.Enums;

namespace CharacterGen.Domain.Spell
{
    public interface ISpell
    {
        void UpdateName(string name);
        void UpdateLevel(int level);
        void UpdateSchool(SpellSchool school);
        void UpdateDescription(string description);
        void UpdateComponents(IEnumerable<SpellComponent> components);
        void UpdateCastingTime(Action castingTime);
        void UpdateIsRitual(bool isRitual);
        void UpdateRange(string range);
        void UpdateCost(int cost);
        void UpdateDuration(string duration);
    }
}