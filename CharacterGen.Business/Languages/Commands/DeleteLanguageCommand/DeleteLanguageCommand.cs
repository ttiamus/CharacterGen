using CharacterGen.Domain;
using CharacterGen.Domain.Languages;

namespace CharacterGen.Business.Languages.Commands.DeleteLanguageCommand
{
    public class DeleteLanguageCommand
    {
        private readonly IValidator<DeleteLanguageRequest> validator;
        private readonly IRepository<Language> languageRepository;

        public DeleteLanguageCommand(IValidator<DeleteLanguageRequest> validator, IRepository<Language> languageRepository)
        {
            this.validator = validator;
            this.languageRepository = languageRepository;
        }

        public void Execute(DeleteLanguageRequest request)
        {
            if (validator.IsRequestValid(request))
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