using System.Runtime.Remoting.Messaging;
using MongoDB.Bson;

namespace CharacterGen.Business.Languages.Commands.UpdateLanguageCommand
{
    public class UpdateLanguageValidator
    {
        public bool IsLanguageValid(UpdateLanguageRequest request)
        {
            var result = true;
            if (string.IsNullOrWhiteSpace(request.Name))
            {
                //log issue
                result = false;
            }  

            if (string.IsNullOrWhiteSpace(request.Description))
            {
                //Log issue
                result = false;
            }

            if (request.Id.Equals(null) || request.Id.Equals(ObjectId.Empty))
            {
                //log issue
                result = false;
            }

            return result;
        }
    }
}