using MongoDB.Bson;

namespace CharacterGen.Business.Languages.Commands.DeleteLanguageCommand
{
    public class DeleteLanguageRequest
    {
        public ObjectId Id { get; set; }
    }
}