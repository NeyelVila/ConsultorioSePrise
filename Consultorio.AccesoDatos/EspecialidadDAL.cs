using MySql.Data.MySqlClient;
using Consultorio.Entidades;
using System.Collections.Generic;

namespace Consultorio.AccesoDatos
{
    public class EspecialidadDAL
    {
        private ConexionMySQL conexion = new ConexionMySQL();

        public List<Especialidad> ListarTodas()
        {
            List<Especialidad> lista = new List<Especialidad>();
            MySqlCommand cmd = new MySqlCommand(
                "SELECT * FROM especialidad ORDER BY Nombre",
                conexion.AbrirConexion());

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    lista.Add(new Especialidad
                    {
                        ID_Especialidad = reader.GetInt32("ID_Especialidad"),
                        Nombre = reader.GetString("Nombre"),
                        Duracion_Minima_Turno = reader.GetInt32("Duracion_Minima_Turno")
                    });
                }
            }
            conexion.CerrarConexion();
            return lista;
        }
    }
}
