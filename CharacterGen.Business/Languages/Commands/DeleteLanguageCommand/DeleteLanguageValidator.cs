using MongoDB.Bson;

namespace CharacterGen.Business.Languages.Commands.DeleteLanguageCommand
{
    public class DeleteLanguageValidator
    {
        public bool IsValidDeleteLanguageRequest(DeleteLanguageRequest request)
        {
            return !request.Id.Equals(null) && !request.Id.Equals(ObjectId.Empty);
        }
    }
}