namespace CharacterGen.Domain.Roleplay
{
    public class Roleplay : IRoleplay
    {
        public string PersonalityTraits { get; set; }
        public string Ideals { get; set; }
        public string Bonds { get; set; }
        public string Flaws { get; set; }
        public string Backstory { get; set; }
    }
}