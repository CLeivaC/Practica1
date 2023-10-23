using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            VentanaLogin main = new VentanaLogin();
            main.FormClosed += VentanaLoginForm_Closed;
            main.Show();

            Application.Run();

        }


        private static void VentanaLoginForm_Closed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= VentanaLoginForm_Closed;

            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
            else
            {
                Application.OpenForms[0].FormClosed += VentanaLoginForm_Closed;
            }
        }

    }
}
