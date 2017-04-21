using System.Linq.Expressions;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;

namespace CharacterGen.Mongo
{
    public class MongoContext
    {
        private readonly MongoClient client;
        private  readonly IMongoDatabase database;
        public MongoContext()
        {
            this.client = new MongoClient(new MongoConfiguration().ConnectionString);
            this.database = client.GetDatabase("character_gen");
        }

        public IMongoCollection<TEntity> Collection<TEntity>() where TEntity : class
        {
            return database.GetCollection<TEntity>(typeof(TEntity).Name);
        }
    }
}