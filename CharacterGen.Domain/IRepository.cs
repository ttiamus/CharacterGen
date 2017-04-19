using System;
using System.Linq;
using System.Linq.Expressions;

namespace CharacterGen.Domain
{
    public interface IRepository<T>
    {
        T Find(params object[] id);
        IQueryable<T> Where(Expression<Func<bool, T>> predicate);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
