using CharacterGen.Domain.Background;
using CharacterGen.Mongo;
using CharacterGen.Mongo.Models;

namespace CharacterGen.Dal.Repositories
{
    public class BackgroundRepository : Repository<Background, BackgroundEntity>
    {
        public BackgroundRepository(IMongoContext context) : base(context) {}
    }
}