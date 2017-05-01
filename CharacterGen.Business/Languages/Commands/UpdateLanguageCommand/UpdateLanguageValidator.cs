using System.Runtime.Remoting.Messaging;
using MongoDB.Bson;

namespace CharacterGen.Business.Languages.Commands.UpdateLanguageCommand
{
    public class UpdateLanguageValidator : IValidator<UpdateLanguageRequest>
    {
        public bool IsRequestValid(UpdateLanguageRequest request)
        {
            var idValid = IsIdValid(request.Id);
            var nameValid = IsNameValid(request.Name);
            var descriptionValid = IsDescriptionValid(request.Description);
            
            return idValid && nameValid && descriptionValid;
        }

        private bool IsIdValid(string id)
        {
            //Log any validation issues
            return !string.IsNullOrWhiteSpace(id);
        }

        private bool IsNameValid(string name)
        {
            //Log any validation issues
            return !string.IsNullOrWhiteSpace(name);
        }

        private bool IsDescriptionValid(string description)
        {
            //Log any validation issues
            return !string.IsNullOrWhiteSpace(description);
        }
    }
}