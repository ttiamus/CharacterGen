using CharacterGen.Domain.Race;
using CharacterGen.Mongo;
using CharacterGen.Mongo.Models;

namespace CharacterGen.Dal.Repositories
{
    public class RaceRepository : Repository<Race, RaceEntity>
    {
        public RaceRepository(IMongoContext context) : base(context) {}
    }
}