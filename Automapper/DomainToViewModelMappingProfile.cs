using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Profile = AutoMapper.Profile;

namespace Automapper
{
    internal class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            //CreateMap<Domain,ViewModel>()

            CreateMap<Domain.Core.Ticket, Services.Core.Ticket.DTOs.TicketCreateDto>();
         
        }


    }
}