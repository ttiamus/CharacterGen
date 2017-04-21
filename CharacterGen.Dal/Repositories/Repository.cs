using System;
using System.Linq;
using System.Linq.Expressions;
using CharacterGen.Domain;
using CharacterGen.Domain.Character;
using CharacterGen.Mongo;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CharacterGen.Dal.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, IAggregateRoot
    {
        private IMongoCollection<T> collection;

        public Repository(MongoContext context)
        {
            this.collection = context.Collection<T>();
        }

        public T Find(ObjectId id)
        {
            return collection.Find(x => x.Id.Equals(id)).FirstOrDefault(); 
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> predicate)
        {
            return collection.AsQueryable().Where(predicate);
        }

        public void Add(T entity)
        {
            collection.InsertOneAsync(entity).Wait();
        }

        public void Update(T entity)
        {
            collection.ReplaceOneAsync(x => x.Id.Equals(entity.Id), entity).Wait();
        }    

        public void Delete(ObjectId id)
        {
            collection.DeleteOneAsync(x => x.Id.Equals(id));
        }
    }
}