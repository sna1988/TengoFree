using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TengoFree.FormFunctions
{
    public class FormHelpers
    {
        public static void LimpiarControles(object obj)
        {
            if (obj is Form)
            {
                foreach (var ctrol in ((Form)obj).Controls)
                {
                    LimpiarControles(ctrol);
                }
            }

            if (obj is Panel)
            {
                foreach (var ctrol in ((Panel)obj).Controls)
                {
                    LimpiarControles(ctrol);
                }
            }

            if (obj is TextBox)
            {
                ((TextBox)obj).Clear();
            }
            if (obj is MetroTextBox)
            {
                ((MetroTextBox)obj).Clear();
            }
            if (obj is ComboBox)
            {
                if (((ComboBox)obj).Items.Count > 0)
                    ((ComboBox)obj).SelectedIndex = 0;
            }
            if (obj is MetroComboBox)
            {
                if (((MetroComboBox)obj).Items.Count > 0)
                    ((MetroComboBox)obj).SelectedIndex = 0;
            }
            if (obj is CheckBox)
            {
                ((CheckBox)obj).Checked = false;
            }
            if (obj is MetroCheckBox)
            {
                ((MetroCheckBox)obj).Checked = false;
            }
            if (obj is MetroToggle)
            {
                ((MetroToggle)obj).Checked = false;
            }
            if (obj is DateTimePicker)
            {
                ((DateTimePicker)obj).Value = DateTime.Now;
            }

        }
    }
}
