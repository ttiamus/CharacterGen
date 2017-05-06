using CharacterGen.Domain.Equipment.AdventuringGear;
using CharacterGen.Mongo;
using CharacterGen.Mongo.Models;

namespace CharacterGen.Dal.Repositories
{
    public class AdventuringGearRepository : Repository<AdventuringGear, AdventuringGearEntity>
    {
        public AdventuringGearRepository(IMongoContext context) : base(context) {}
    }
}