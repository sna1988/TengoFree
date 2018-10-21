using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationTools.Enums;

namespace PresentacionBase.Clases
{
    public static  class InicializadorDiccionarios
    {
        public static List<ComboBoxEnum> DocumentTypeDictionary()
        {
        
            return new List<ComboBoxEnum>(
                new[]
                {
                new ComboBoxEnum(){EnumValue = (int)DocumentType.DNI,DisplayName = "DNI"}
                ,new ComboBoxEnum(){EnumValue = (int)DocumentType.LibretaEnrolamiento,DisplayName = "Libreta de Enrolamiento"}
                    ,new ComboBoxEnum(){EnumValue = (int)DocumentType.LibretaCivica,DisplayName = "Libreta Cívica"}
                    ,new ComboBoxEnum(){EnumValue = (int)DocumentType.Pasaporte,DisplayName = "Pasaporte"}
                    ,new ComboBoxEnum(){EnumValue = (int)DocumentType.PoliciaFederal,DisplayName = "Cédula Federal"}

                });
        }

        public static List<ComboBoxEnum> YearDictionary()
        {
            var listYear=new List<ComboBoxEnum>();
            var list=new List<ComboBoxEnum>();
            list.Add(new ComboBoxEnum() { EnumValue = -1, DisplayName = "Todos" });
            for (int i = 0; i < 20; i++)
            {

                listYear.Add(new ComboBoxEnum(){EnumValue = DateTime.Now.Year-i,DisplayName = (DateTime.Now.Year-i).ToString()});
            }

            list.AddRange(listYear.OrderByDescending(o=>o.EnumValue).ToList());
            return list;
        }
        public static List<ComboBoxEnum> MonthDictionary()
        {

            return new List<ComboBoxEnum>(
                new[]
                {
                    new ComboBoxEnum(){EnumValue = -1,DisplayName = "Todos"},
                    new ComboBoxEnum(){EnumValue = (int)Months.Enero,DisplayName = "Enero"}
                    ,new ComboBoxEnum(){EnumValue = (int)Months.Febrero,DisplayName = "Febrero"}
                    ,new ComboBoxEnum(){EnumValue = (int)Months.Marzo,DisplayName = "Marzo"}
                    ,new ComboBoxEnum(){EnumValue = (int)Months.Abril,DisplayName = "Abril"}
                    ,new ComboBoxEnum(){EnumValue = (int)Months.Mayo,DisplayName = "Mayo"}
                    ,new ComboBoxEnum(){EnumValue = (int)Months.Junio,DisplayName = "Junio"}
                    ,new ComboBoxEnum(){EnumValue = (int)Months.Julio,DisplayName = "Julio"}
                    ,new ComboBoxEnum(){EnumValue = (int)Months.Agosto,DisplayName = "Agosto"}
                    ,new ComboBoxEnum(){EnumValue = (int)Months.Septiembre,DisplayName = "Septiembre"}
                    ,new ComboBoxEnum(){EnumValue = (int)Months.Octubre,DisplayName = "Octubre"}
                    ,new ComboBoxEnum(){EnumValue = (int)Months.Noviembre,DisplayName = "Noviembre"}
                    ,new ComboBoxEnum(){EnumValue = (int)Months.Diciembre,DisplayName = "Diciembre"}


                }).OrderBy(o=>o.EnumValue).ToList();
        }
        public static List<ComboBoxEnum> GenderDictionary()
        {

            return new List<ComboBoxEnum>(
                new[]
                {
                    new ComboBoxEnum(){EnumValue = (int)Gender.Hombre,DisplayName = "Hombre"}
                    ,new ComboBoxEnum(){EnumValue = (int)Gender.Mujer,DisplayName = "Mujer"}
                    ,new ComboBoxEnum(){EnumValue = (int)Gender.NoRegistra,DisplayName = "No Registra"}
                });
        }

        public static List<ComboBoxEnum> ConceptTypeDictionary()
        {

            return new List<ComboBoxEnum>(
                new[]
                {
                    new ComboBoxEnum(){EnumValue = (int)ConceptType.Remunerativo,DisplayName = "Remunerativo"}
                    ,new ComboBoxEnum(){EnumValue = (int)ConceptType.NoRemunerativo,DisplayName = "No Remunerativo"}
                    ,new ComboBoxEnum(){EnumValue = (int)ConceptType.Retencion,DisplayName = "Retención"}
                    ,new ComboBoxEnum(){EnumValue = (int)ConceptType.Haber,DisplayName = "Haber"}
                });
        }
    }
}
