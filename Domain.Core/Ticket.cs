
using Aplication.Enums;
using Domain.Base.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core
{
    public class Ticket : EntityBase
    {


        
        public int Number { get; set; }

        public DateTime CreationDate { get; set; }

        public TicketArea  Area { get; set; }


        public string Name { get; set; }


        public string LastName { get; set; }


        public string Telephone { get; set; }


        public string Email { get; set; }


        public string Description { get; set; }



    }
}
