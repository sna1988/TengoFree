
using Aplication.Enums;
using System;

namespace DataTransferObjects.Ticket
{
    public class TicketListDto
    {
        public Guid? Id { get; set; }
        public DateTime CreationDate { get; set; }

        public int Number { get; set; }
        public TicketArea TicketArea { get; set; }

        public string Name { get; set; }
        public string LastName { get; set; }

        public string CompleteName => string.Concat(LastName, " ", Name);
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Description { get; set; }

       


    }
}
