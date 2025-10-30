using MySql.Data.MySqlClient;
using System.Data;

namespace Consultorio.AccesoDatos
{
    public class ConexionMySQL
    {
        // ¡IMPORTANTE! Cambia "tu_contraseña" por tu contraseña real de MySQL.
        private string connectionString = "Server=127.0.0.1;Database=db_consultorio_seprise;Uid=root;Pwd=;";
        private MySqlConnection conexion;

        public ConexionMySQL()
        {
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

