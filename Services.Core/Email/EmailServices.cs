using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Nustache.Core;
using Services.Core.Properties;
using Services.Core.Ticket.DTOs;

namespace Services.Core.Email
{
    public class EmailServices : IEmailServices
    {
        // Scopes for Google application Credential
        static string[] Scopes = { GmailService.Scope.GmailInsert,GmailService.Scope.GmailReadonly,GmailService.Scope.GmailSend };

        // Google Aplication Name
        static string ApplicationName = "DBTengoFree";

        // Google service used for google mailing managment.
        static GmailService Service;

        public EmailServices()
        {
            if (Service==null)
            {
                CreateGmailService();
            }
            
        }

        /// <summary>
        ///  Creates Mail Message once the ticket was created.
        /// </summary>
        /// <param name="dto">Ticket with the information to be sent</param>
        /// <returns></returns>

        public MailMessage CreateMail(TicketCreateDto dto)
        {
            try
            {
                byte[] bytes;
                var template = Properties.Resources.EmailTemplate;

                var html = Render.StringToString(template, dto);

                MailMessage message = new MailMessage("sna1988@gmail.com", dto.Email, "TengoFree - Ticket N°: " + dto.Number, dto.Description);

                message.From = new MailAddress("sna1988@gmail.com");
                message.Bcc.Add(new MailAddress("silcultura@gmail.com"));
                message.To.Add(new MailAddress(dto.Email));
                message.Subject = "TengoFree - Ticket N°: " + dto.Number;
                message.Body = html;
                message.IsBodyHtml = true;
                return message;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        /// <summary>
        /// Send Mails From Google Account
        /// </summary>
        /// <param name="dto">Created Ticket (Saved on Db)</param>
        public void SendMail(TicketCreateDto dto)
        {

            try
            {
                // Convert MailMessage to MimeMessage.
                var mimeMessage = MimeKit.MimeMessage.CreateFromMailMessage(CreateMail(dto));

                //Create a Google Mail Message Object to be sent.
                Message messageGmail = new Message()
                {

                    Raw = Encode(mimeMessage.ToString()),
                };

                // Create a google send message request.
                var request = Service.Users.Messages.Send(messageGmail, "me");

                // Execute GoogleSendMessage Request. Returns Message Sent.
                var response = request.Execute();

            }
            catch (Exception ex)
            {

                throw ex;
            }  

        }



        /// <summary>
        ///  Create a Google Mail Service using downloaded Credentials
        /// </summary>
        private void CreateGmailService()
        {
            try
            {
                UserCredential credential;

                // Retrieve byte[] from resource file credential.
                var cred = Resources.client_id;


                string credPath = "token.json";

                // Create a google Credential to access Google Aplication.
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(new MemoryStream(cred)).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);




                // Create Google Sheets API service.

                Service = new GmailService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private string Encode(string text)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(text);

            return System.Convert.ToBase64String(bytes)
                .Replace('+', '-')
                .Replace('/', '_')
                .Replace("=", "");
        }
    }
}
