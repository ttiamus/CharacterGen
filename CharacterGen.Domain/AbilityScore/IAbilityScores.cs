namespace CharacterGen.Domain.AbilityScore
{
    public interface IAbilityScores
    {
        void UpdateStrength(int strength);
        void UpdateDexterity(int dexterity);
        void UpdateConsitution(int constitution);
        void UpdateIntelligence(int intelligence);
        void UpdateWisdom(int wisdom);
        void UpdateCharisma(int charisma);
        void UpdateAbilityScores(AbilityScores abilityScores);
    }
}