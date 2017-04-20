namespace CharacterGen.Business.Languages.Commands.CreateLanguageCommand
{
    public class CreateLanguageValidator
    {
        public bool IsLanguageValid(CreateLanguageRequest request)
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

            return result;
        }
    }
}