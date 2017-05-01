using MongoDB.Bson;

namespace CharacterGen.Business.Languages.Commands.DeleteLanguageCommand
{
    public class DeleteLanguageRequest : IRequest
    {
        public string Id { get; set; }
    }
}