
using Automapper;
using AutoMapper;

namespace Servicio.RecursosHumanos.Automapper
{
    
    public static class AutomapperConfiguration
    {
       
        public static void Configure()
        {
            Mapper.Initialize(x =>
                {

                    x.AddProfile<DomainToViewModelMappingProfile>();
                    x.AddProfile< ViewModelToDomainMappingProfile>();

                }
            );
               
        }
    }
}
