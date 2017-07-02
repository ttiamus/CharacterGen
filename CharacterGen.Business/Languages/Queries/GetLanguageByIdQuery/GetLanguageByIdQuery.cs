using System;
using CharacterGen.Common.Exceptions;
using CharacterGen.Domain;
using CharacterGen.Domain.Languages;

namespace CharacterGen.Business.Languages.Queries.GetLanguageByIdQuery
{
    public class GetLanguageByIdQuery
    {
        private readonly IValidator<GetLanguageByIdRequest> validator;
        private readonly IRepository<Language> languageRepository;

        public GetLanguageByIdQuery(IValidator<GetLanguageByIdRequest> validator, IRepository<Language> languageRepository)
        {
            this.validator = validator;
            this.languageRepository = languageRepository;
        }

        public Language Execute(GetLanguageByIdRequest request)
        {
            if (validator.IsRequestValid(request))
            {
                var language = languageRepository.Find(request.Id);
                if(language == null)
                    throw new ResourceNotFoundException($"Language with Id: {request.Id} could not be found");
                return language;
            }
            else
            {
                throw new ArgumentException("Execute Language request was invalid");
                //Log problem
            }
        }
    }
}