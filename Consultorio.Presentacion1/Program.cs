using Consultorio.Presentacion1;
using System;
using System.Windows.Forms;

namespace Consultorio.Presentacion
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Cambiamos Form1 por frmLogin
            Application.Run(new frmLogin());
        }
    }
}