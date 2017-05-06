using CharacterGen.Domain.Feat;
using CharacterGen.Mongo;
using CharacterGen.Mongo.Models;

namespace CharacterGen.Dal.Repositories
{
    public class FeatRepository : Repository<Feat, FeatEntity>
    {
        public FeatRepository(IMongoContext context) : base(context) {}
    }
}