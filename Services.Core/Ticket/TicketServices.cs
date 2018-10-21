
using Aplication.Enums;
using Domain.Base.Repository;
using Domain.Base.UnitOfWork;
using Services.Core.Ticket.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.Core.Ticket
{
    public class TicketServices : ITicketServices
    {
        private readonly IRepository<Domain.Core.Ticket> _ticketRepository;

        private readonly IUnitOfWork _uow;
        

        public TicketServices(IRepository<Domain.Core.Ticket> ticketRepository,IUnitOfWork uow)
        {
            _ticketRepository = ticketRepository;
            
            _uow = uow;
        }

        public TicketCreateDto Create(string name, string lastName, TicketArea area, string telephone, string email, string description)
        {
            var ticket = new Domain.Core.Ticket()
            {
                Name = name,
                LastName = lastName,
                Area = area,

                Description = description,
                Email = email,
                Telephone = telephone,
                CreationDate = DateTime.Now,
                Number = CreateTicketNumber()
            };
            _ticketRepository.Add(ticket);
            
            return new TicketCreateDto()
            {
                Area = ticket.Area,
                CreationDate=ticket.CreationDate,
                Description=ticket.Description,
                Email=ticket.Email,
                LastName=ticket.LastName,
                Name=ticket.Name,
                Number=ticket.Number,
                Telephone=ticket.Telephone
            };


        }

        public int CreateTicketNumber()
        {
            var random = new Random().Next(10000, 99999);
            return random;
        }

        public TicketDto GetTicketById(Guid id)
        {

            var ticket = _ticketRepository.GetById(id);
            return new TicketDto()
            {
                Id = ticket.Id,
                CreationDate = ticket.CreationDate,
                Description = ticket.Description,
                Email = ticket.Email,
                LastName = ticket.LastName,
                Name = ticket.Name,
                Number = ticket.Number,
                Telephone = ticket.Telephone,
                TicketArea = ticket.Area
            };
        }

        public IEnumerable<TicketListDto> GetTickets()
        {
            return _ticketRepository.GetAll().Select(s => new TicketListDto()
            {
                Id = s.Id,
                CreationDate = s.CreationDate,
                Number = s.Number,
                Name = s.Name,
                LastName = s.LastName,
                Description = s.Description,
                Email = s.Email,
                Telephone = s.Telephone,
                TicketArea = s.Area

            }).OrderByDescending(o=>o.CreationDate).ToList();
            
        }
    }
}
