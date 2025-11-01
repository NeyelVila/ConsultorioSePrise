using Consultorio.Presentacion1; // Usas este para acceder a tus formularios
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

            // --- INICIO DE LA MODIFICACIÓN ---

            // 1. Creamos el formulario de configuración.
            // (frmConfiguracionDB está en el namespace Consultorio.Presentacion1)
            frmConfiguracionDB frmConfig = new frmConfiguracionDB();

            // 2. Lo mostramos como un "diálogo". La aplicación se detiene aquí
            //    hasta que ese formulario se cierre.
            if (frmConfig.ShowDialog() == DialogResult.OK)
            {
                // 3. Si el formulario se cerró con "DialogResult.OK"
                //    (lo cual hicimos en el botón "Probar y Guardar"),
                //    entonces significa que la conexión fue exitosa.
                //    Procedemos a mostrar el Login.
                //    (frmLogin también está en Consultorio.Presentacion1)
                Application.Run(new frmLogin());
            }
            else
            {
                // 4. Si el usuario cerró la ventana de configuración
                //    sin presionar "Probar y Guardar", cerramos la aplicación.
                Application.Exit();
            }

            // --- FIN DE LA MODIFICACIÓN ---
            // La línea original "Application.Run(new frmLogin());"
            // se reemplaza por todo el bloque if/else de arriba.
        }
    }
}