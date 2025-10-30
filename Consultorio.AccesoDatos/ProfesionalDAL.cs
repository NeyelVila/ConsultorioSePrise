using MySql.Data.MySqlClient;
using Consultorio.Entidades;
using System.Collections.Generic;

namespace Consultorio.AccesoDatos
{
    public class ProfesionalDAL
    {
        private ConexionMySQL conexion = new ConexionMySQL();

        public List<Profesional> ListarPorEspecialidad(int idEspecialidad)
        {
            List<Profesional> lista = new List<Profesional>();
            MySqlCommand cmd = new MySqlCommand(
                "SELECT * FROM profesional WHERE ID_Especialidad = @idEspecialidad ORDER BY Apellido, Nombre",
                conexion.AbrirConexion());

            cmd.Parameters.AddWithValue("@idEspecialidad", idEspecialidad);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    lista.Add(new Profesional
                    {
                        ID_Profesional = reader.GetInt32("ID_Profesional"),
                        Matricula = reader.GetString("Matricula"),
                        Nombre = reader.GetString("Nombre"),
                        Apellido = reader.GetString("Apellido"),
                        ID_Especialidad = reader.GetInt32("ID_Especialidad")
                    });
                }
            }
            conexion.CerrarConexion();
            return lista;
        }
    }
}