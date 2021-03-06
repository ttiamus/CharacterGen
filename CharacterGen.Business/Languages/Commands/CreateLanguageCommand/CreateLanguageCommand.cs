﻿using System;
using CharacterGen.Domain;
using CharacterGen.Domain.Languages;

namespace CharacterGen.Business.Languages.Commands.CreateLanguageCommand
{
    public class CreateLanguageCommand
    {
        private readonly IValidator<CreateLanguageRequest> validator;
        private readonly IRepository<Language> languageRepository;

        public CreateLanguageCommand(IValidator<CreateLanguageRequest> validator, IRepository<Language> languageRepository)
        {
            this.validator = validator;
            this.languageRepository = languageRepository;
        }

        public void Execute(CreateLanguageRequest request)
        {
            if (validator.IsRequestValid(request))
            {
                var language = new Language();  //TODO: Change to a factory
                language.UpdateName(request.Name);
                language.UpdateDescription(request.Description);

                languageRepository.Add(language);
            }
            else
            {
                //Log problem
                throw new ArgumentException("Create Language Request was invlid");
            }
        }
    }
}