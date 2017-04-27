using MongoDB.Driver;

namespace CharacterGen.Mongo
{
    public interface IMongoContext
    {
        IMongoCollection<TEntity> Collection<TEntity>() where TEntity : class;
    }
}