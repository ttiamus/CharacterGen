using Headspring;

namespace CharacterGen.Domain.Enumerations
{
    public class Alignment : Enumeration<Alignment, string>
    {
        public Alignment(string value, string displayName) : base(value, displayName) { }

        public static readonly Alignment LawfulGood = new Alignment("LG", "Lawful Good");
        public static readonly Alignment NeutralGood = new Alignment("NG", "Neutral Good");
        public static readonly Alignment ChaoticGood = new Alignment("CG", "Chaotic Good");
        public static readonly Alignment LawfulNeutral = new Alignment("LN", "Lawful Neutral");
        public static readonly Alignment TrueNeutral = new Alignment("TN", "True Neutral");
        public static readonly Alignment ChaoticNeutral = new Alignment("CN", "Chaotic Neutral");
        public static readonly Alignment LawfulEvil = new Alignment("LE", "Lawful Evil");
        public static readonly Alignment NeutralEvil = new Alignment("NE", "Neutral Evil");
        public static readonly Alignment ChaoticEvil = new Alignment("CE", "Chaotic Evil");
    }
}
