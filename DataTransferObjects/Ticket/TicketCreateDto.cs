using Aplication.Enums;
using System;

namespace DataTransferObjects.Ticket
{
    public class TicketCreateDto
    {

        
        public int Number { get; set; }

        public DateTime CreationDate { get; set; }

        public string DateStr => CreationDate.ToString("dd/MM/yyyy HH:mm");

        public TicketArea  Area { get; set; }

        public string AreaStr
        {
            get
            {
                switch (Area)
                {
                    case TicketArea.Administracion:
                        return "Administracón";
                        break;
                    case TicketArea.Pagos:
                        return "Pagos";
                        break;
                    case TicketArea.Tecnico:
                        return "Técnico";
                        break;
                    case TicketArea.Otros:
                        return "Otros";
                        break;
                    default:
                        return string.Empty;
                        break;
                }
            }
        }


        public string Name { get; set; }


        public string LastName { get; set; }

        public string CompleteName => string.Concat(LastName, " ", Name);
        public string Telephone { get; set; }

        

        public string Email { get; set; }

        

        public string Description { get; set; }

        
    }
}
