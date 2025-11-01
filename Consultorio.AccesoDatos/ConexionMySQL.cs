using MySql.Data.MySqlClient;
using System.Data;
using System; // Asegúrate de tener este using

namespace Consultorio.AccesoDatos
{
    public class ConexionMySQL
    {
        // Ya no definimos la cadena aquí
        private string connectionString;
        private MySqlConnection conexion;

        public ConexionMySQL()
        {
            // Lee la cadena de conexión que se guardó en el login
            this.connectionString = ConfiguracionConexion.ConnectionString;

            // Si nadie ha iniciado sesión, la cadena estará vacía.
            // Es buena idea agregar un control para esto.
            if (string.IsNullOrEmpty(this.connectionString))
            {
                throw new InvalidOperationException("La conexión no ha sido inicializada. (¿Se inició sesión correctamente?)");
            }

            conexion = new MySqlConnection(connectionString);
        }

        public MySqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }

        public MySqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            return conexion;
        }
    }
}
