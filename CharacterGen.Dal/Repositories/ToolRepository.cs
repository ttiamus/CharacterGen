using CharacterGen.Domain.Equipment.Tool;
using CharacterGen.Mongo;
using CharacterGen.Mongo.Models;

namespace CharacterGen.Dal.Repositories
{
    public class ToolRepository : Repository<Tool, ToolEntity>
    {
        public ToolRepository(IMongoContext context) : base(context) {}
    }
}