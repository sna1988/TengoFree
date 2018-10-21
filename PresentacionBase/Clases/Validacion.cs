using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PresentacionBase.Clases
{
    public class Validacion
    {
        public static void NoLetras(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || (Char.IsWhiteSpace(e.KeyChar) || Char.IsUpper(e.KeyChar) || Convert.ToInt32(e.KeyChar) == 22))
            {
                e.Handled = true;
            }
        }
        public static void NoNumeros(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Convert.ToInt32(e.KeyChar) == 2)
            {
                e.Handled = true;
            }
        }

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

        public static void NoInyeccion(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '{' || e.KeyChar == '}' || e.KeyChar == '(' || e.KeyChar == ')' || e.KeyChar == ';' || e.KeyChar == '+' || e.KeyChar == '"' || (int)e.KeyChar == 39)
            {
                e.Handled = true;
            }
        }

        public static bool ValidarEmail(string Email, ErrorProvider errorProvider, TextBox textBox)
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
    }
}
