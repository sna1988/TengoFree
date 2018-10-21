

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
        TicketCreateDto Create(string name, string lastName, TicketArea area, string telephone, string email, string description);

        int CreateTicketNumber();

        IEnumerable<TicketListDto> GetTickets();
        TicketDto GetTicketById(Guid id);
    }
}
