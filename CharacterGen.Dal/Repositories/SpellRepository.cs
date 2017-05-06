using CharacterGen.Domain;
using CharacterGen.Domain.Spell;
using CharacterGen.Mongo;
using CharacterGen.Mongo.Models;

namespace CharacterGen.Dal.Repositories
{
    public class SpellRepository : Repository<Spell, SpellEntity>
    {
        public SpellRepository(IMongoContext context) : base(context) {}
    }
}