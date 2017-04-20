namespace CharacterGen.Domain.Roleplay
{
    public interface IRoleplay
    {
        void UpdatePersonalityTrait(string personalityTrait);
        void UpdateIdeal(string ideal);
        void UpdateBond(string bond);
        void UpdateFlaw(string flaw);
        void UpdateBackstory(string backstory);
        void UpdateRoleplay(Roleplay roleplay);
    }
}