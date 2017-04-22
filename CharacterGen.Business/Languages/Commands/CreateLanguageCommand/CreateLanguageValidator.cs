namespace CharacterGen.Business.Languages.Commands.CreateLanguageCommand
{
    public class CreateLanguageValidator
    {
        public bool IsRequestValid(CreateLanguageRequest request)
        {
            var nameValid = IsNameValid(request.Name);
            var descriptionValid = IsDescriptionValid(request.Description);

            return nameValid && descriptionValid;
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