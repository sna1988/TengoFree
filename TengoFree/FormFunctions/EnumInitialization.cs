using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TengoFree
{
    public static class EnumInitialization
    {
        public static List<ComboBoxEnum> AreaInitialization()
        {
            return new List<ComboBoxEnum>(
               new[]
               {
                new ComboBoxEnum(){EnumValue = (int)Aplication.Enums.TicketArea.Administracion,DisplayName = "Administración"}
                ,new ComboBoxEnum(){EnumValue = (int)Aplication.Enums.TicketArea.Pagos,DisplayName = "Pagos"}
                    ,new ComboBoxEnum(){EnumValue = (int)Aplication.Enums.TicketArea.Tecnico,DisplayName = "Técnico"}
                    ,new ComboBoxEnum(){EnumValue = (int)Aplication.Enums.TicketArea.Otros,DisplayName = "Otros"}
               });
        }
    }

    public  class ComboBoxEnum
    {
        public int EnumValue { get; set; }
        public string DisplayName { get; set; }
    }
}
