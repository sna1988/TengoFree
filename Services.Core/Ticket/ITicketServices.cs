

using Aplication.Enums;
using Services.Core.Ticket.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Core.Ticket
{
    public interface ITicketServices
    {
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
        TicketCreateDto Create(string name, string lastName, TicketArea area, string telephone, string email, string description);

        /// <summary>
        /// Crfeates a new Random number for ticket of 5 digits.
        /// </summary>
        /// <returns>Random number of 5 digits</returns>
        int CreateTicketNumber();

        /// <summary>
        /// Retrieve all tickets in the DB
        /// </summary>
        /// <returns>List of TicketListDto ordered by date descending</returns>
        IEnumerable<TicketListDto> GetTickets();

        /// <summary>
        /// Gets ticket By Id.
        /// </summary>
        /// <param name="id">Ticket Guid Id</param>
        /// <returns>Ticket Dto with the tickets values</returns>
        TicketDto GetTicketById(Guid id);
    }
}
