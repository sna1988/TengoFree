
using System.Net.Mail;

namespace Aplication.Interfaces.Email
{
    public interface IEmailServices
    {

        /// <summary>
        ///  Creates Mail Message once the ticket was created.
        /// </summary>
        /// <param name="dto">Ticket with the information to be sent</param>
        /// <returns></returns>
        MailMessage CreateMail(DataTransferObjects.Ticket.TicketCreateDto dto);


        /// <summary>
        /// Send Mails From Google Account
        /// </summary>
        /// <param name="dto">Created Ticket (Saved on Db)</param>
        void SendMail(DataTransferObjects.Ticket.TicketCreateDto dto);
    }
}