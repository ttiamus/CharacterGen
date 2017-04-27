using System;
using CharacterGen.Mongo;
using MongoDB.Driver;

namespace CharacterGen.Business.Tests
{
    public class MongoContextTestHelper : IMongoContext
    {
        private readonly MongoClient client;
        private readonly IMongoDatabase database;
        public MongoContextTestHelper()
        {
            this.client = new MongoClient(new MongoConfiguration().ConnectionString);
            this.database = client.GetDatabase("character_gen_tests");
        }

        public IMongoCollection<TEntity> Collection<TEntity>() where TEntity : class
        {
            return database.GetCollection<TEntity>(typeof(TEntity).Name);
        }
    }
}