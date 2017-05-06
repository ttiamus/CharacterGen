using CharacterGen.Domain.Class;
using CharacterGen.Domain.Feat;
using CharacterGen.Mongo;
using CharacterGen.Mongo.Models;

namespace CharacterGen.Dal.Repositories
{
    public class ClassRepository : Repository<Class, ClassEntity>
    {
        public ClassRepository(IMongoContext context) : base(context) {}
    }
}