using System.Collections;
using System.Collections.Generic;
using CharacterGen.Domain.Enums;
using MongoDB.Bson;

namespace CharacterGen.Domain.Spell
{
    public class Spell : ISpell
    {
        public ObjectId Id { get; set; }
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
        public void UpdateName(string name)
        {
            this.Name = name;
        }

        public void UpdateLevel(int level)
        {
            this.Level = level;
        }

        public void UpdateSchool(SpellSchool school)
        {
            this.School = school;
        }

        public void UpdateDescription(string description)
        {
            this.Description = description;
        }

        public void UpdateComponents(IEnumerable<SpellComponent> components)
        {
            this.Components = components;
        }

        public void UpdateCastingTime(Action castingTime)
        {
            this.CastingTime = castingTime;
        }

        public void UpdateIsRitual(bool isRitual)
        {
            this.IsRitual = isRitual;
        }

        public void UpdateRange(string range)
        {
            this.Range = range;
        }

        public void UpdateCost(int cost)
        {
            this.Cost = cost;
        }

        public void UpdateDuration(string duration)
        {
            this.Duration = duration;
        }
    }
}
