using System.Data.Entity;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using Infrastructure.Encriptado;

namespace Infrastructure.Contexto
{
    public class Inicializador : CreateDatabaseIfNotExists<EfDbContext>
    {
        protected override void Seed(EfDbContext context)
        {
            base.Seed(context);

        
        }

      
    }
}
