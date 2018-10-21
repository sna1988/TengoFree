using System.Data.Entity;
using StructureMap;
using Domain.Base.Repository;
using Infrastructure;

using Domain.Base.UnitOfWork;


using Services.Core.Ticket;


namespace Aplication.IoC
{
    public class StructureMapContainer
    {
        
        /// <summary>
        /// Configure
        /// </summary>
        public void Configure()
        {

            
            ObjectFactory.Configure(x =>
            {
                x.Scan(scan =>
                {
                    // Automatically maps interface IXyz to class Xyz
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                    scan.ConnectImplementationsToTypesClosing(typeof(IRepository<>));
                    scan.Assembly(GetType().Assembly);
                });


                x.ForSingletonOf<DbContext>().HybridHttpOrThreadLocalScoped();
                //x.ForSingletonOf<DbContext>().Singleton();
                x.For(typeof(IUnitOfWork)).Use(typeof(UnitOfWork));
                x.For(typeof(IRepository<>)).Use(typeof(Repository<>));
                
              
                x.For(typeof(ITicketServices)).Use(typeof(TicketServices));
                
               
                
            });
        }
    }
}
