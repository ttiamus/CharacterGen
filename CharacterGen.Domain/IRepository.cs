using System;
using System.Linq;
using System.Linq.Expressions;
using MongoDB.Bson;

namespace CharacterGen.Domain
{
    public interface IRepository<T>
    {
        T Find(string id);
        IQueryable<T> GetAll();
        IQueryable<T> Where(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Update(T entity);
        void Delete(string id);
    }
}
