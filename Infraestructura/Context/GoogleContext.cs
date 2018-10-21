using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;
using Infraestructura.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Infraestructura.Context
{
    public class GoogleContext
    {
        static string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static string ApplicationName = "DBTengoFree";
        public SheetsService Service;
        public  String spreadsheetId = "1t6dcu3zBTtuofV_BB3Ja3I0ihZ0WyiFpDJfNUXZZC-g";
        public  String range = "Ticket!A2:I";

        public GoogleContext()
        {
            GoogleCredential credential;

            var credFile = Resources.DBTengoFree_231c58ffa8af;

           
            //using (var stream =
            //  new FileStream("Certificados/DBTengoFree-231c58ffa8af.json", FileMode.Open, FileAccess.Read))
            //{
            

                string credPath = "token.json";
                credential = GoogleCredential.FromStream(new MemoryStream(credFile)).CreateScoped(Scopes);
              

            //}

            // Create Google Sheets API service.

            Service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer=credential,
                ApplicationName = ApplicationName,
            });
            
            // Define request parameters.
           
         
        }
    }
}
