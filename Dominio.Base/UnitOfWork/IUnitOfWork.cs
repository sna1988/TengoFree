using System.Collections.Generic;
using Domain.Base.Entity;
using Domain.Base.Repository;

namespace Domain.Base.UnitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<TEntity> Repository<TEntity>() where TEntity : EntityBase;

        IEnumerable<TEntity> ExecuteSp<TEntity>(string nombreSp, List<BaseParameterSp> parametros = null) where TEntity : EntityBase;

        void ExecuterSp(string nombreSp, List<BaseParameterSp> parametros = null);

        void Commit();
    }
}
