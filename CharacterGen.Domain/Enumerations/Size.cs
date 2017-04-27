using Headspring;

namespace CharacterGen.Domain.Enumerations
{
    public class Size : Enumeration<Size, string>
    {
        public Size(string value, string displayName) : base(value, displayName) {}

        public static readonly Size Tiny = new Size("Tiny","Tiny");
        public static readonly Size Small = new Size("Small", "Small");
        public static readonly Size Medium = new Size("Medium", "Medium");
        public static readonly Size Large = new Size("Large", "Large");
        public static readonly Size Huge = new Size("Huge", "Huge");
    }
}