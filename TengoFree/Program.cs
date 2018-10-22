using System;
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
                // Initialize Ioc.
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
