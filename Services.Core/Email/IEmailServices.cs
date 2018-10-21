using Services.Core.Ticket.DTOs;
using System.Net.Mail;

namespace Services.Core.Email
{
    public interface IEmailServices
    {

        /// <summary>
        ///  Creates Mail Message once the ticket was created.
        /// </summary>
        /// <param name="dto">Ticket with the information to be sent</param>
        /// <returns></returns>
        MailMessage CreateMail(TicketCreateDto dto);


        /// <summary>
        /// Send Mails From Google Account
        /// </summary>
        /// <param name="dto">Created Ticket (Saved on Db)</param>
        void SendMail(TicketCreateDto dto);
    }
}