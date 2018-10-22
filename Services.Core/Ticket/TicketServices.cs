
using Aplication.Enums;
using Aplication.Interfaces.Ticket;
using AutoMapper;
using Domain.Base.Repository;
using Domain.Base.UnitOfWork;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.Core.Ticket
{
    public class TicketServices : ITicketServices
    {
        private readonly IRepository<Domain.Core.Ticket> _ticketRepository;

        private readonly IUnitOfWork _uow;

        private readonly IMapper _mapper;

        public TicketServices(IRepository<Domain.Core.Ticket> ticketRepository,IUnitOfWork uow,IMapper mapper)
        {
            _ticketRepository = ticketRepository;
            _mapper = mapper;
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
        public DataTransferObjects.Ticket.TicketCreateDto Create(string name, string lastName, TicketArea area, string telephone, string email, string description)
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
            return _mapper.Map<Domain.Core.Ticket, DataTransferObjects.Ticket.TicketCreateDto>(ticket);
            


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
        public DataTransferObjects.Ticket.TicketDto GetTicketById(Guid id)
        {

            // retrieve ticket entity
            var ticket = _ticketRepository.GetById(id);

            // convert ticket entity to ticket Dto;
            return _mapper.Map<Domain.Core.Ticket, DataTransferObjects.Ticket.TicketDto>(ticket);
         
        }


        /// <summary>
        /// Retrieve all tickets in the DB
        /// </summary>
        /// <returns>List of TicketListDto ordered by date descending</returns>
        public IEnumerable<DataTransferObjects.Ticket.TicketListDto> GetTickets()
        {

            return _mapper.Map<IEnumerable<Domain.Core.Ticket>, IEnumerable<DataTransferObjects.Ticket.TicketListDto>>(_ticketRepository.GetAll().OrderByDescending(o => o.CreationDate).ToList());
           
            
        }
    }
}
