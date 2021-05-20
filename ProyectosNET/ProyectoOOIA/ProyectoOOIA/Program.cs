using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoOOIA.Componentes;
using ProyectoOOIA.Ventanas;

namespace ProyectoOOIA
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmInicioSesion pantalla = new frmInicioSesion();

            pantalla.FormClosed += MainForm_Closed;
            pantalla.Show();

            //Application.Run(new frmHorarioCita());
            Application.Run();
        }
        private static void MainForm_Closed(Object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= MainForm_Closed;

            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
            else
            {
                Application.OpenForms[0].FormClosed += MainForm_Closed;
            }
        }
    }
}
