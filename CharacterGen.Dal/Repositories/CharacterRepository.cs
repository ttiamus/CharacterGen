using System;
using System.Linq;
using System.Linq.Expressions;
using CharacterGen.Domain;
using CharacterGen.Domain.Character;
using CharacterGen.Mongo;
using MongoDB.Driver;

namespace CharacterGen.Dal.Repositories
{
    public class CharacterRepository : IRepository<Character>
    {
        private IMongoCollection<Character> characters;

        public CharacterRepository(MongoContext context)
        {
            this.characters = context.Collection<Character>();
        }

        public Character Find(params object[] id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Character> Where(Expression<Func<bool, Character>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Add(Character entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Character entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Character entity)
        {
            throw new NotImplementedException();
        }
    }
}