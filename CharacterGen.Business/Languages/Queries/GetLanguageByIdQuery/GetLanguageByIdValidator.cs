using MongoDB.Bson;

namespace CharacterGen.Business.Languages.Queries.GetLanguageByIdQuery
{
    public class GetLanguageByIdValidator
    {
        public bool IsRequestValid(GetLanguageByIdRequest request)
        {
            return ValidateId(request.Id);
        }

        private bool ValidateId(string id)
        {
            return !string.IsNullOrWhiteSpace(id);
        }
    }
}