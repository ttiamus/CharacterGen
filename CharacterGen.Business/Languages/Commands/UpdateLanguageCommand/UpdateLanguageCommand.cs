using CharacterGen.Domain;
using CharacterGen.Domain.Languages;

namespace CharacterGen.Business.Languages.Commands.UpdateLanguageCommand
{
    public class UpdateLanguageCommand
    {
        private readonly IValidator<UpdateLanguageRequest> validator;
        private readonly IRepository<Language> languageRepository;

        public UpdateLanguageCommand(IValidator<UpdateLanguageRequest> validator, IRepository<Language> languageRepository)
        {
            this.validator = validator;
            this.languageRepository = languageRepository;
        }

        public void Execute(UpdateLanguageRequest request)
        {
            if (validator.IsRequestValid(request))
            {
                var language = languageRepository.Find(request.Id);
                language.UpdateName(request.Name);
                language.UpdateDescription(request.Description);

                languageRepository.Update(language);
            }
            else
            {
                //Log problem
            }
        }
    }
}