

using AutoMapper;
using Services.Core.Ticket.DTOs;

namespace Aplication.AutoMapper
{
    public class DtoToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DtoToDomainMapping"; }
        }

        protected override void Configure()
        {

            CreateMap<Domain.Core.Ticket, TicketCreateDto>();

        }
    }
}