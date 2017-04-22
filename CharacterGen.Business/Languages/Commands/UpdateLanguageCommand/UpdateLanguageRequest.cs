using MongoDB.Bson;

namespace CharacterGen.Business.Languages.Commands.UpdateLanguageCommand
{
    public class UpdateLanguageRequest
    {
        public string Id {get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
    }
}