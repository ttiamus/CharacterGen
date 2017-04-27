using Headspring;

namespace CharacterGen.Domain.Enumerations
{
    public class Dice : Enumeration<Dice, int>
    {
        public Dice(int value, string displayName) : base(value, displayName) {}

        //TODO: Figure out handle cases like 2d6
        public static readonly Dice D4 = new Dice(4, "D4");
        public static readonly Dice D6 = new Dice(6, "D6");
        public static readonly Dice D8 = new Dice(8, "D8");
        public static readonly Dice D10 = new Dice(10, "D10");
        public static readonly Dice D12 = new Dice(12, "D12");
    }
}