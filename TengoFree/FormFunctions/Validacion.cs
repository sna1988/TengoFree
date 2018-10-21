using MetroFramework.Controls;
using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TengoFree
{
    public class Validacion
    {

        /// <summary>
        /// Prevent user to insert Letter Char.
        /// </summary>
        /// <param name="sender">object to check </param>
        /// <param name="e">event keypress</param>
        public static void NoLetras(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || (Char.IsWhiteSpace(e.KeyChar) || Char.IsUpper(e.KeyChar) || Convert.ToInt32(e.KeyChar) == 22))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Prevent user to insert Number Char.
        /// </summary>
        /// <param name="sender">object to check </param>
        /// <param name="e">event keypress</param>
        public static void NoNumeros(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Convert.ToInt32(e.KeyChar) == 2)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Prevent user to insert Symbol Char.
        /// </summary>
        /// <param name="sender">object to check </param>
        /// <param name="e">event keypress</param>
        public static void NoSimbolos(object sender, KeyPressEventArgs e)
        {
            if (Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Convert.ToInt32(e.KeyChar) == 2)
            {
                e.Handled = true;
            }
        }

        public static void VerificarNoVacios(object sender, CancelEventArgs e, ErrorProvider error)
        {
            if (sender is TextBox)
            {
                if (string.IsNullOrEmpty(((TextBox)sender).Text))
                {
                    error.SetError(((TextBox)sender), !string.IsNullOrEmpty(((TextBox)sender).Text) ? string.Empty : "Campo Obligatorio");
                    e.Cancel = true;
                }
                else
                {
                    error.SetError(((TextBox)sender), "");
                }
                return;
            }

            if (sender is NumericUpDown)
            {
                if (string.IsNullOrEmpty(((NumericUpDown)sender).Text))
                {
                    error.SetError(((NumericUpDown)sender), !string.IsNullOrEmpty(((NumericUpDown)sender).Text) ? string.Empty : "Campo Obligatorio");
                    e.Cancel = true;
                }
                else
                {
                    error.Clear();
                }
                return;
            }

            if (sender is ComboBox)
            {
                if (((ComboBox)sender).Items.Count <= 0)
                {
                    error.SetError(((ComboBox)sender), (((ComboBox)sender).Items.Count > 0) ? string.Empty : "Campo Obligatorio");
                    e.Cancel = true;
                }
                else
                {
                    error.Clear();
                }
                return;
            }
        }

        /// <summary>
        /// Prevent user to insert Injection Char.
        /// </summary>
        /// <param name="sender">object to check </param>
        /// <param name="e">event keypress</param>
        public static void NoInyeccion(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '{' || e.KeyChar == '}' || e.KeyChar == '(' || e.KeyChar == ')' || e.KeyChar == ';' || e.KeyChar == '+' || e.KeyChar == '"' || (int)e.KeyChar == 39)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Validate Email Format is valid
        /// </summary>
        /// <param name="Email">email to check</param>
        /// <param name="errorProvider">error provider to set error</param>
        /// <param name="textBox">textbox to asociate errorprovider</param>
        /// <returns>true: if it's well formated. false: is not a valid mail.</returns>
        public static bool ValidarEmail(string Email, ErrorProvider errorProvider, MetroTextBox textBox)
        {
            bool Estado = false;
            String expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(Email, expresion))
            {
                if (Regex.Replace(Email, expresion, String.Empty).Length == 0)
                {
                    errorProvider.SetError(textBox, string.Empty);
                    Estado = true;
                }
                else
                {
                    errorProvider.SetError(textBox, "Formato del Mail Incorrecto");
                }
            }
            else
            {
                errorProvider.SetError(textBox, "Formato del Mail Incorrecto");
            }
            return Estado;
        }

        public static bool CheckPasswordEquals(TextBox txtPass,TextBox txtConfirm)
        {
            if (string.IsNullOrWhiteSpace(txtConfirm.Text)||string.IsNullOrEmpty(txtConfirm.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPass.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                return false;
            }
            if (txtPass.Text!=txtConfirm.Text)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Check if controls has value.
        /// </summary>
        /// <param name="controlesParaVerificar">Controls to check</param>
        /// <returns>true: all controls has value. false: one or more controls is empty</returns>
        public static bool VerificarDatosObligatorios(object[] controlesParaVerificar)
        {
            if (controlesParaVerificar != null)
            {
                foreach (var ctrol in controlesParaVerificar)
                {
                   
                    if (ctrol is MetroTextBox)
                    {
                        if (!VerificarSiTieneDatosCtrol(((MetroTextBox)ctrol)))
                            return false;
                    }



                    if (ctrol is MetroComboBox)
                    {
                        if (!VerificarSiTieneDatosCtrol(((MetroComboBox)ctrol)))
                            return false;
                    }
                }
            }

            return true;
        }

       /// <summary>
       /// check if metrotextbox has value 
       /// </summary>
       /// <param name="txt">metrotextbox to check</param>
       /// <returns>true: has value. false:is empty </returns>
        private static bool VerificarSiTieneDatosCtrol(MetroTextBox txt)
        {
            return !string.IsNullOrEmpty(txt.Text.Trim()) && !string.IsNullOrWhiteSpace(txt.Text.Trim());
        }

        /// <summary>
        /// check if metrocombobox has value 
        /// </summary>
        /// <param name="txt">metrotextbox to check</param>
        /// <returns>true: has value. false:is empty </returns>
        private static bool VerificarSiTieneDatosCtrol(MetroComboBox cmb)
        {
            return !string.IsNullOrEmpty(cmb.Text) && !string.IsNullOrWhiteSpace(cmb.Text) && cmb.Items.Count > 0;
        }

       
    }
}
