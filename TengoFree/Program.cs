using Autofac;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace TengoFree
{
    static class Program
    {
        
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {

                Composition.Initialize(new IoC.Configuration());
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(Composition.Resolve<_00001_Principal>());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
       
    }
}
