using MySql.Data.MySqlClient;
using Consultorio.Entidades;
using System;

namespace Consultorio.AccesoDatos
{    public class HistoriaClinicaDAL
    {
        private ConexionMySQL conexion = new ConexionMySQL();

        public HistoriaClinica ObtenerPorPacienteID(int idPaciente)
        {
            HistoriaClinica hc = null;
            MySqlCommand cmd = new MySqlCommand(
                "SELECT * FROM historia_clinica WHERE ID_Paciente = @idPaciente",
                conexion.AbrirConexion());
            cmd.Parameters.AddWithValue("@idPaciente", idPaciente);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    hc = new HistoriaClinica
                    {
                        ID_Historia_Clinica = reader.GetInt32("ID_Historia_Clinica"),
                        ID_Paciente = reader.GetInt32("ID_Paciente"),
                        Fecha_Creacion = reader.GetDateTime("Fecha_Creacion"),
                        Notas_Generales = reader.IsDBNull(reader.GetOrdinal("Notas_Generales")) ? "" : reader.GetString("Notas_Generales")
                    };
                }
            }
            conexion.CerrarConexion();
            return hc;
        }

        public int Crear(int idPaciente)
        {
            MySqlCommand cmd = new MySqlCommand(
                @"INSERT INTO historia_clinica (ID_Paciente, Fecha_Creacion) 
                  VALUES (@idPaciente, NOW());
                  SELECT LAST_INSERT_ID();",
                conexion.AbrirConexion());
            cmd.Parameters.AddWithValue("@idPaciente", idPaciente);

            int nuevoId = Convert.ToInt32(cmd.ExecuteScalar());
            conexion.CerrarConexion();
            return nuevoId;
        }
    }
}