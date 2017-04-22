using System.Collections.Generic;
using CharacterGen.Domain;
using CharacterGen.Domain.Languages;

namespace CharacterGen.Business.Languages.Queries.GetLanguagesQuery
{
    public class GetLanguagesCommand
    {
        private readonly IRepository<Language> languageRepository;

        public GetLanguagesCommand(IRepository<Language> languageRepository)
        {
            this.languageRepository = languageRepository;
        }

        public IEnumerable<Language> Execute(GetLanguagesRequest request)
        {
            return languageRepository.GetAll();
        }
    }
}