using CharacterGen.Domain.Equipment.WonderousItem;
using CharacterGen.Mongo;
using CharacterGen.Mongo.Models;

namespace CharacterGen.Dal.Repositories
{
    public class WonderousItemRepository : Repository<WonderousItem, WonderousItemEntity>
    {
        public WonderousItemRepository(IMongoContext context) : base(context) {}
    }
}