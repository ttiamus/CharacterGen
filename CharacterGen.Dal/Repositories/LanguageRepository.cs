using System;
using System.Linq;
using System.Linq.Expressions;
using CharacterGen.Domain;
using CharacterGen.Domain.Languages;

namespace CharacterGen.Dal.Repositories
{
    public class LanguageRepository : IRepository<Language>
    {
        public Language Find(params object[] id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Language> Where(Expression<Func<bool, Language>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Add(Language entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Language entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Language entity)
        {
            throw new NotImplementedException();
        }
    }
}