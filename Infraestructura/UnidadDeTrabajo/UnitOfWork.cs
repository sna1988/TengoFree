using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using Domain.Base.Entity;
using Domain.Base.Repository;
using Domain.Base.UnitOfWork;
using Infraestructura.Context;
using Infrastructure;
using Infrastructure.Context;

namespace Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private Dictionary<string, object> _repositories;
        private GoogleContext _googleContext;
        private readonly EfDbContext _context;
        private bool _disposed;

        public UnitOfWork(GoogleContext context)
        {
            _googleContext = context;
            
        }

        public IRepository<T> Repository<T>() where T : EntityBase
        {
            if (_repositories == null)
            {
                _repositories = new Dictionary<string, object>();
            }

            var type = typeof (T).Name;

            if (_repositories.ContainsKey(type)) return (Repository<T>) _repositories[type];


            var repositoryType = typeof (Repository<>);

            var repositoryInstancie = Activator.CreateInstance(repositoryType.MakeGenericType(typeof (T)), _context);
            _repositories.Add(type, repositoryInstancie);


            return (Repository<T>) _repositories[type];
        }

        public IEnumerable<TEntity> ExecuteSp<TEntity>(string nameSp,
            List<BaseParameterSp> parameters = null) where TEntity : EntityBase
        {
            var objContext = ((IObjectContextAdapter)_context).ObjectContext;

            if (objContext.Connection.State != ConnectionState.Open)
                objContext.Connection.Open();

            var command = objContext.Connection.CreateCommand();

            command.CommandText = nameSp.Trim();
            command.CommandTimeout = TimeSpan.MaxValue.Milliseconds;
            command.CommandType = CommandType.StoredProcedure;

            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    var newParameter = command.CreateParameter();
                    newParameter.Direction = param.Direction;
                    newParameter.DbType = param.ParameterType;
                    newParameter.ParameterName = param.Name;
                    newParameter.Value = param.Value;

                    command.Parameters.Add(newParameter);
                }
            }

            var result = objContext.Translate<TEntity>(command.ExecuteReader());

            return result.ToList();
        }

        public void ExecuterSp(string nameSp, List<BaseParameterSp> parameters = null)
        {
            var objContext = ((IObjectContextAdapter)_context).ObjectContext;

            if (objContext.Connection.State != ConnectionState.Open)
                objContext.Connection.Open();

            var command = objContext.Connection.CreateCommand();

            command.CommandText = nameSp.Trim();
            command.CommandTimeout = TimeSpan.MaxValue.Milliseconds;
            command.CommandType = CommandType.StoredProcedure;

            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    var newParameter = command.CreateParameter();
                    newParameter.Direction = param.Direction;
                    newParameter.DbType = param.ParameterType;
                    newParameter.ParameterName = param.Name;
                    newParameter.Value = param.Value;

                    command.Parameters.Add(newParameter);
                }
            }

            objContext.ExecuteStoreCommandAsync(nameSp, command.Parameters);
        }

        public void Commit()
        {
            
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    this._context.Dispose();
                }
            }

            _disposed = true;
        }
    }
}
