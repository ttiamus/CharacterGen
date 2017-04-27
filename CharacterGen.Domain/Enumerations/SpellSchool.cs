using Headspring;

namespace CharacterGen.Domain.Enumerations
{
    public class SpellSchool : Enumeration<SpellSchool, string>
    {
        public SpellSchool(string value, string displayName) : base(value, displayName) {}

        public static readonly SpellSchool Abjuration = new SpellSchool("Abjuration", "Abjuration");
        public static readonly SpellSchool Conjuration = new SpellSchool("Conjuration", "Conjuration");
        public static readonly SpellSchool Enchantment = new SpellSchool("Enchantment", "Enchantment");
        public static readonly SpellSchool Evocation = new SpellSchool("Evocation", "Evocation");
        public static readonly SpellSchool Illusion = new SpellSchool("Illusion", "Illusion");
        public static readonly SpellSchool Necromancy = new SpellSchool("Necromancy", "Necromancy");
        public static readonly SpellSchool Transmutation = new SpellSchool("Transmutation", "Transmutation");
    }
}