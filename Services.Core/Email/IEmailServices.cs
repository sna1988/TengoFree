using Services.Core.Ticket.DTOs;
using System.Net.Mail;

namespace Services.Core.Email
{
    public interface IEmailServices
    {
         MailMessage CreateMail(TicketCreateDto dto);
        void SendMail(TicketCreateDto dto);
    }
}