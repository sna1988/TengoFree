using Autofac;
using Domain.Base.Repository;
using Domain.Base.UnitOfWork;
using Infrastructure;
using Ninject.Modules;
using Services.Core.Email;
using Services.Core.Ticket;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC
{
    public  class Configuration: NinjectModule
    {

        public override void Load()
        {
            Bind<IEmailServices>().To<EmailServices>();
            Bind<ITicketServices>().To<TicketServices>();
            Bind<IUnitOfWork>().To<UnitOfWork>();
            Bind(typeof(IRepository<>)).To(typeof(Repository<>));
            Bind<DbContext>().ToSelf().InSingletonScope();
        }
        
      
    }
}
