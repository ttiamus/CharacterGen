namespace CharacterGen.Domain.Languages
{
    public interface ILanguage
    {
        void UpdateName(string name);
        void UpdateDescription(string description);
    }
}