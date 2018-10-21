using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Domain.Base.Repository
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Delete(long entityId);
        void Delete(T entity);
        void Update(T entity);

        T GetById(Guid entityId, string includeProperty = "");
        IEnumerable<T> GetAll(string includeProperty = "");
        IEnumerable<T> GetByFilter(Expression<Func<T, bool>> filter, string includeProperty = "");
    }
}
