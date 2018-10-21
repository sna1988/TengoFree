using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionBase
{
    public static class Mensaje
    {
        public static DialogResult Mostrar(IWin32Window owner, string mensajeMostrar, TipoMensaje tipoMensaje)
        {
            
            switch (tipoMensaje)
            {

                case TipoMensaje.Aviso:
                    return MetroFramework.MetroMessageBox.Show(owner, mensajeMostrar, "Aviso:",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    
                case TipoMensaje.Error:
                    return MetroFramework.MetroMessageBox.Show(owner, mensajeMostrar, "Error:", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                case TipoMensaje.Pregunta:
                    return MetroFramework.MetroMessageBox.Show(owner, mensajeMostrar, "Pregunta:",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                case TipoMensaje.Info:
                    return MetroFramework.MetroMessageBox.Show(owner, mensajeMostrar, "Información:",
                        MessageBoxButtons.OK, MessageBoxIcon.None);

                case TipoMensaje.Confirmacion:
                    return MetroFramework.MetroMessageBox.Show(owner, mensajeMostrar, "Confirmación:",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);

            }

            return DialogResult.OK;
        }

        public static void Mostrar(Exception ex)
        {
            MessageBox.Show(ex.Message, "Error Grave", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

    }
}
