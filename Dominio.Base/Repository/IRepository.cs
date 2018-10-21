using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Domain.Base.Repository
{
    public interface IRepository<T>
    {
        void Add(T entity);
        

        T GetById(Guid entityId, string includeProperty = "");
        IEnumerable<T> GetAll(string includeProperty = "");
  
    }
}
