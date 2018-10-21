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
        static string[] Scopes = { GmailService.Scope.GmailInsert,GmailService.Scope.GmailReadonly,GmailService.Scope.GmailSend };
        static string ApplicationName = "DBTengoFree";
        static GmailService Service;

        public EmailServices()
        {
            if (Service==null)
            {
                CreateGmailService();
            }
            
        }


        public MailMessage CreateMail(TicketCreateDto dto)
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

        public void SendMail(TicketCreateDto dto)
        {
 
            var mimeMessage = MimeKit.MimeMessage.CreateFromMailMessage(CreateMail(dto));

            Message messageGmail = new Message()
            {
                
                Raw = Encode(mimeMessage.ToString()),
            };
            var request=Service.Users.Messages.Send(messageGmail, "me");
            var response = request.Execute();
            

        }

        private void CreateGmailService()
        {
            UserCredential credential;

            var cred = Resources.client_id;

                string credPath = "token.json";
                
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
