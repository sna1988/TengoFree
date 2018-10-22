using AutoMapper;
using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC
{
    public class AutoMapperModule
    {


        public static IMapper AutoMapper(Ninject.Activation.IContext context)
        {
            Mapper.Initialize(config =>
            {
                config.ConstructServicesUsing(type => context.Kernel.Get(type));

                config.CreateMap<Domain.Core.Ticket, DataTransferObjects.Ticket.TicketListDto>()
                .ForMember(dto=>dto.TicketArea,m=>m.MapFrom(x=>x.Area));
                config.CreateMap<Domain.Core.Ticket, DataTransferObjects.Ticket.TicketDto>()
                .ForMember(dto => dto.TicketArea, m => m.MapFrom(x => x.Area)); 
                config.CreateMap<Domain.Core.Ticket, DataTransferObjects.Ticket.TicketCreateDto>()
                .ForMember(dto => dto.Area, m => m.MapFrom(x => x.Area)); 
//                config.CreateMap<MySource, MyDest>();
                // .... other mappings, Profiles, etc.              

            });

            Mapper.AssertConfigurationIsValid(); // optional
            return Mapper.Instance;
        }
    }
}
