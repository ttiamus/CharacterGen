using System;
using CharacterGen.Common.Exceptions;
using CharacterGen.Domain;
using CharacterGen.Domain.Spell;

namespace CharacterGen.Business.Spells.Queries.GetSpellByIdQuery
{
    public class GetSpellByIdQuery
    {
        private readonly IValidator<GetSpellByIdRequest> validator;
        private readonly IRepository<Spell> spellRepository;

        public GetSpellByIdQuery(IValidator<GetSpellByIdRequest> validator, IRepository<Spell> spellRepository)
        {
            this.validator = validator;
            this.spellRepository = spellRepository;
        }

        public Spell Execute(GetSpellByIdRequest request)
        {
            if (validator.IsRequestValid(request))
            {
                var spell = spellRepository.Find(request.Id);
                if (spell == null)
                    throw new ResourceNotFoundException($"Spell with Id: {request.Id} could not be found");
                return spell;
            }
            else
            {
                throw new ArgumentException("Execute GetSpellByIdRequest was invalid");
                //Log problem
            }
        }
    }
}