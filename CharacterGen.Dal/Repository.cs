using System;
using System.Linq;
using System.Linq.Expressions;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using CharacterGen.Domain;
using CharacterGen.Domain.Character;
using CharacterGen.Mongo;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CharacterGen.Dal
{
    public abstract class Repository<Domain, Entity> : IRepository<Domain> 
        where Domain : class
        where Entity : class, IEntity
    {
        private IMongoCollection<Entity> collection;

        protected Repository(IMongoContext context)
        {
            this.collection = context.Collection<Entity>();
        }

        public Domain Find(string id)
        {
            var entity = collection.Find(x => x.Id.Equals(id)).FirstOrDefault();
            return Mapper.Map<Domain>(entity);
        }

        public IQueryable<Domain> GetAll()
        {
            return collection               //Return the collection
                    .AsQueryable()          //As a queryable
                    .ProjectTo<Domain>();   //Map entities in collection to the domain object
        }

        public IQueryable<Domain> Where(Expression<Func<Domain, bool>> predicate)
        { 
            /*Expression<Func<Entity, bool>> expr2 =
              Expression.Lambda<Func<Entity, bool>>(predicate.Body, predicate.Parameters);

            //Expression<Func<LanguageEntity, bool>> predicate2 = predicate;
            var entities = collection.AsQueryable().Where(expr2);
            return Mapper.Map<IQueryable<Domain>>(entities);
            */

            return GetAll().Where(predicate);
        }

        public void Add(Domain domain)
        {
            var entity = Mapper.Map<Entity>(domain);
            collection.InsertOneAsync(entity).Wait();
        }

        public void Update(Domain domain)
        {
            var entity = Mapper.Map<Entity>(domain);
            collection.ReplaceOneAsync(x => x.Id.Equals(entity.Id), entity).Wait();
        }    

        public void Delete(string id)
        {
            collection.DeleteOneAsync(x => x.Id.Equals(id));
        }
    }
}