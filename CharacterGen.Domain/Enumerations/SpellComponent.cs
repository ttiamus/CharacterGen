using Headspring;

namespace CharacterGen.Domain.Enumerations
{
    

    public class SpellComponent : Enumeration<SpellComponent, string>
    {
        public SpellComponent(string value, string displayName) : base(value, displayName) { }
        public static readonly SpellComponent Verbal = new SpellComponent("Verbal", "Verbal");
        public static readonly SpellComponent Somatic = new SpellComponent("Somatic", "Somatic");
        public static readonly SpellComponent Material = new SpellComponent("Material", "Material");
    }
}