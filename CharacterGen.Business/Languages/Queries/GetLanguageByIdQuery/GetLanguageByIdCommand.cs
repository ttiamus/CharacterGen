using System;
using CharacterGen.Domain;
using CharacterGen.Domain.Languages;

namespace CharacterGen.Business.Languages.Queries.GetLanguageByIdQuery
{
    public class GetLanguageByIdCommand
    {
        private readonly IValidator<GetLanguageByIdRequest> validator;
        private readonly IRepository<Language> languageRepository;

        public GetLanguageByIdCommand(IValidator<GetLanguageByIdRequest> validator, IRepository<Language> languageRepository)
        {
            this.validator = validator;
            this.languageRepository = languageRepository;
        }

        public Language Execute(GetLanguageByIdRequest request)
        {
            if (validator.IsRequestValid(request))
            {
                return languageRepository.Find(request.Id);
            }
            else
            {
                throw new NotImplementedException();
                //Log problem
            }
        }
    }
}