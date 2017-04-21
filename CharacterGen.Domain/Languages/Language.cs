using MongoDB.Bson;

namespace CharacterGen.Domain.Languages
{
    public class Language : ILanguage, IAggregateRoot
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public void UpdateName(string name)
        {
            this.Name = name;
        }

        public void UpdateDescription(string description)
        {
            this.Description = description;
        }
    }
}