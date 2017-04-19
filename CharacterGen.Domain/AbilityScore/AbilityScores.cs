using MongoDB.Bson;

namespace CharacterGen.Domain.AbilityScore
{
    public class AbilityScores : IAbilityScores
    {
        public ObjectId Id { get; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        public void UpdateStrength(int strength)
        {
            this.Strength = strength;
        }

        public void UpdateDexterity(int dexterity)
        {
            this.Dexterity = dexterity;
        }

        public void UpdateConsitution(int constitution)
        {
            this.Constitution = constitution;
        }

        public void UpdateIntelligence(int intelligence)
        {
            this.Intelligence = intelligence;
        }

        public void UpdateWisdom(int wisdom)
        {
            this.Wisdom = wisdom;
        }

        public void UpdateCharisma(int charisma)
        {
            this.Charisma = charisma;
        }

        public void UpdateAbilityScores(AbilityScores abilityScores)
        {
            UpdateStrength(abilityScores.Strength);
            UpdateDexterity(abilityScores.Dexterity);
            UpdateConsitution(abilityScores.Constitution);
            UpdateIntelligence(abilityScores.Intelligence);
            UpdateWisdom(abilityScores.Wisdom);
            UpdateCharisma(abilityScores.Charisma);
        }
    }
}