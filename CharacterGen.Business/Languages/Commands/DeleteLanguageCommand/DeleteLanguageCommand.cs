using CharacterGen.Domain;
using CharacterGen.Domain.Languages;

namespace CharacterGen.Business.Languages.Commands.DeleteLanguageCommand
{
    public class DeleteLanguageCommand
    {
        private readonly DeleteLanguageValidator validator;
        private readonly IRepository<Language> languageRepository;

        public DeleteLanguageCommand(DeleteLanguageValidator validator, IRepository<Language> languageRepository)
        {
            this.validator = validator;
            this.languageRepository = languageRepository;
        }

        public void Execute(DeleteLanguageRequest request)
        {
            if (validator.IsValidDeleteLanguageRequest(request))
            {
                languageRepository.Delete(request.Id);
            }
            else
            {
                //Log problem
            }
        }
    }
}