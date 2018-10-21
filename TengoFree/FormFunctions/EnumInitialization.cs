using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TengoFree
{
    public static class EnumInitialization
    {
        /// <summary>
        /// Create a list of values to be inserted in a combobox from ticketArea enum
        /// </summary>
        /// <returns>List<ComboBoxEnum> to be inserted in combobox</ComboBoxEnum></ComboBoxValue></returns>
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


    /// <summary>
    /// Helper class to format enums to be displayed on combobox
    /// </summary>
    public  class ComboBoxEnum
    {
        public int EnumValue { get; set; }
        public string DisplayName { get; set; }
    }
}
