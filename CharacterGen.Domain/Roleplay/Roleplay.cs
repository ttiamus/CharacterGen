namespace CharacterGen.Domain.Roleplay
{
    public class Roleplay : IRoleplay
    {
        public string PersonalityTrait { get; set; }
        public string Ideal { get; set; }
        public string Bond { get; set; }
        public string Flaw { get; set; }
        public string Backstory { get; set; }

        public void UpdatePersonalityTrait(string personalityTrait)
        {
            this.PersonalityTrait = personalityTrait;
        }

        public void UpdateIdeal(string ideal)
        {
            this.Ideal = ideal;
        }

        public void UpdateBond(string bond)
        {
            this.Bond = bond;
        }

        public void UpdateFlaw(string flaw)
        {
            this.Flaw = flaw;
        }

        public void UpdateBackstory(string backstory)
        {
            this.Backstory = backstory;
        }

        public void UpdateRoleplay(Roleplay roleplay)
        {
            UpdatePersonalityTrait(roleplay.PersonalityTrait);
            UpdateIdeal(roleplay.Ideal);
            UpdateBond(roleplay.Bond);
            UpdateFlaw(roleplay.Flaw);
            UpdateBackstory(roleplay.Backstory);
        }
    }
}