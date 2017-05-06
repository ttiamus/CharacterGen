using CharacterGen.Domain.Equipment.Weapon;
using CharacterGen.Mongo;
using CharacterGen.Mongo.Models;

namespace CharacterGen.Dal.Repositories
{
    public class WeaponRepository : Repository<Weapon, WeaponEntity>
    {
        public WeaponRepository(IMongoContext context) : base(context) {}
    }
}