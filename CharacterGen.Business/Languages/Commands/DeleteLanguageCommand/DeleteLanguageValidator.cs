using MongoDB.Bson;

namespace CharacterGen.Business.Languages.Commands.DeleteLanguageCommand
{
    public class DeleteLanguageValidator : IValidator<DeleteLanguageRequest>
    {
        public bool IsRequestValid(DeleteLanguageRequest request)
        {
            return IsIdValid(request.Id);
        }

        private bool IsIdValid(string id)
        {
            //Log any validation issues
            return !string.IsNullOrWhiteSpace(id);
        }
    }
}