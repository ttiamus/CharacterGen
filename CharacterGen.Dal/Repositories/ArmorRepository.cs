using CharacterGen.Domain.Equipment.Armor;
using CharacterGen.Mongo;
using CharacterGen.Mongo.Models;

namespace CharacterGen.Dal.Repositories
{
    public class ArmorRepository : Repository<Armor, ArmorEntity>
    {
        public ArmorRepository(IMongoContext context) : base(context) {}
    }
}