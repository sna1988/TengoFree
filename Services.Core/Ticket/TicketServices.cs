
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

        /// <summary>
        /// Insert a new Ticket into Db.
        /// </summary>
        /// <param name="name">Person Name</param>
        /// <param name="lastName">Person Lastname</param>
        /// <param name="area">Ticket Area</param>
        /// <param name="telephone">Person telephone number</param>
        /// <param name="email">Person email where to send Mail</param>
        /// <param name="description">Ticket Description</param>
        /// <returns> Ticket created with creation datetime and ticket Guid Id</returns>
        public TicketCreateDto Create(string name, string lastName, TicketArea area, string telephone, string email, string description)
        {
            // Creates new Ticket entity
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
            
            // save entity into DB
            _ticketRepository.Add(ticket);
            
            // creates new TicketCreateDto to return
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
        /// <summary>
        /// Crfeates a new Random number for ticket of 5 digits.
        /// </summary>
        /// <returns>Random number of 5 digits</returns>
        public int CreateTicketNumber()
        {
            var random = new Random().Next(10000, 99999);
            return random;
        }

        /// <summary>
        /// Gets ticket By Id.
        /// </summary>
        /// <param name="id">Ticket Guid Id</param>
        /// <returns>Ticket Dto with the tickets values</returns>
        public TicketDto GetTicketById(Guid id)
        {

            // retrieve ticket entity
            var ticket = _ticketRepository.GetById(id);

            // convert ticket entity to ticket Dto;
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


        /// <summary>
        /// Retrieve all tickets in the DB
        /// </summary>
        /// <returns>List of TicketListDto ordered by date descending</returns>
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
